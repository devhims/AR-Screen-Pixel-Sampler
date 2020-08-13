using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RawImage))]
public class RawImageColor : MonoBehaviour
{
    public static RawImageColor Instance;

    [HideInInspector]
    public RawImage image;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }

        Instance = this;
        image = GetComponent<RawImage>();
    }
}
