using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
using UnityEngine.UI;

public class VFXController : MonoBehaviour
{
    [SerializeField] VisualEffect visualEffect;
    [Header("Color Settings")]
    [SerializeField] private Slider red;
    [SerializeField] private Slider green;
    [SerializeField] private Slider blue;

    public void ChangeLighting() {

        Vector4 newColor = new (red.value, green.value, blue.value);
        visualEffect.SetVector4("Lighting", newColor);
        visualEffect.SetVector4("Flash", newColor);
        visualEffect.SetVector4("Sparks", newColor);
    }


}
