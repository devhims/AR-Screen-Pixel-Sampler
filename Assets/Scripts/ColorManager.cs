using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public static Dictionary<SkinnedMeshRenderer, Color> recoloredRenderers = new Dictionary<SkinnedMeshRenderer, Color>();

    public void ResetColors()
    {
        foreach (var renderer in recoloredRenderers)
        {
            renderer.Key.material.color = renderer.Value;
        }
    }

}
