using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitrateControl : MonoBehaviour
{
    public MeshRenderer meshRendererCf;
    public MeshRenderer meshRendererBt;
    public Color NewColor;

    // Start is called before the first frame update
    void Start()
    {
        meshRendererCf = GetComponent<MeshRenderer>();
        meshRendererBt = GetComponent<MeshRenderer>();
    }

   public void AcidOut()
    {
        meshRendererBt.material.SetFloat("_Fill", 0.185f);
    }

   /* public void AcidIn()
    {
        meshRendererCf.material.SetFloat("_Fill", 0.31f);
    }*/

    public void AcidTwoOut()
    {
        meshRendererBt.material.SetFloat("_Fill", 0.187f);
    }

    public void AcidThreeOut()
    {
        meshRendererBt.material.SetFloat("_Fill", 0.187f);
    }

    public void RefillBurette()
    {
        meshRendererBt.material.SetFloat("_Fill", 0.52f);
    }
    public void TitrationColorChange()
    {
        meshRendererCf.material.color = NewColor;

    }
}
