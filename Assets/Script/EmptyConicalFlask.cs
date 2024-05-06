using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyConicalFlask : MonoBehaviour
{
    public MeshRenderer meshRendererCf;
   

    // Start is called before the first frame update
    void Start()
    {
        meshRendererCf = GetComponent<MeshRenderer>();
    }

   public void PourOut()
    {
        meshRendererCf.material.SetFloat("_Fill", 0.2f);
    }

    public void BackWhiteColor()
    {
        meshRendererCf.material.SetColor("_SideColor", Color.white);
    }
}
