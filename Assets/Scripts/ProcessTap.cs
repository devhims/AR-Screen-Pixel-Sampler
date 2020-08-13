using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcessTap : MonoBehaviour
{
    SkinnedMeshRenderer meshRenderer;
    MeshCollider meshCollider;
    Color originalColor;
    float time = 0;

    public static bool onMesh = false;

    private void Awake()
    {
        meshRenderer = GetComponent<SkinnedMeshRenderer>();
        meshCollider = GetComponent<MeshCollider>();
        originalColor = meshRenderer.material.color;
    }

    void Update()
    {
        time += Time.deltaTime;
        if (time >= 0.5f)
        {
            time = 0;
            UpdateCollider();
        }
    }

    public void UpdateCollider()
    {
        Mesh colliderMesh = new Mesh();
        meshRenderer.BakeMesh(colliderMesh);
        meshCollider.sharedMesh = null;
        meshCollider.sharedMesh = colliderMesh;
    }

    private void OnMouseDown()
    {
        meshRenderer.material.color = RawImageColor.Instance.image.color;

        if (!ColorManager.recoloredRenderers.ContainsKey(meshRenderer))
        {
            ColorManager.recoloredRenderers.Add(meshRenderer, originalColor);
        }

        onMesh = true;
    }

    private void OnMouseUp()
    {
        onMesh = false;
    }
}
