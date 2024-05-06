using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddIndicatorCf : MonoBehaviour
{
    public MeshRenderer meshRendererCf;
    public GameObject TitrationFluid;
    public string hexColor = "#FFA500FF"; // Example: Orange color with full opacity


    // Start is called before the first frame update
    void Start()
    {
        meshRendererCf = GetComponent<MeshRenderer>();
    }

    public void IndicatorColorChange()
    {
        Color newColor;
        ColorUtility.TryParseHtmlString(hexColor, out newColor); // Parse without checking result
        meshRendererCf.material.color = newColor; // Directly set the color


        //meshRendererCf.material.SetColor("_SideColor", new Color(1.0f, 0.65f, 0.0f, 1.0f)); //Orange color
        // Setting the color using RGBA values directly
        //renderer.material.SetColor("_SideColor", new Color(1.0f, 0.65f, 0.0f, 1.0f)); // Orange color

    }

}
