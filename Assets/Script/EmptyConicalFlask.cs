using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyConicalFlask : MonoBehaviour
{
    public MeshRenderer meshRendererCf;
    public GameObject TitrationFluid;
   

    // Start is called before the first frame update
    void Start()
    {
        meshRendererCf = GetComponent<MeshRenderer>();
    }

   public void PourOut()
    {
       // meshRendererCf.material.SetFloat("_Fill", 0.2f);

       TitrationFluid.SetActive(false);
    }

    /*public void BackWhiteColor()
    {
        meshRendererCf.material.SetColor("_SideColor", Color.white);
    }*/
}
