using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorController : MonoBehaviour
{
    [Header("Color Settings")]
    [SerializeField] private Slider red;
    [SerializeField] private Slider green;
    [SerializeField] private Slider blue;
    [SerializeField] Slider speed;
    [SerializeField] Renderer renderer;
    [SerializeField] Light light;
    Material material;
    
    // Start is called before the first frame update
    void Start()
    {
        material = renderer.material;
        Color currentColor = material.GetColor("_Basecolor");
    }

    public void ChangeColor() {
        MaterialPropertyBlock propertyBlock = new MaterialPropertyBlock();
        Color newColor = new Color(red.value, green.value, blue.value);
        propertyBlock.SetColor("_Basecolor", newColor);
        renderer.SetPropertyBlock(propertyBlock);
    }

    public void ChangeLightColor() {
        Color newColor = new (red.value, green.value, blue.value);
        light.color= newColor;
    }

    public void ChangeSpeed() {
        MaterialPropertyBlock propertyBlock = new MaterialPropertyBlock();
        Vector2 newSpeed = new Vector2(0, speed.value);
        propertyBlock.SetVector("_normalspeed", newSpeed);
        renderer.SetPropertyBlock(propertyBlock);
    }

}
