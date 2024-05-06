using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitrateControl : MonoBehaviour
{
    public MeshRenderer meshRendererCf;
    public MeshRenderer meshRendererBt;

    // Start is called before the first frame update
    void Start()
    {
        meshRendererCf = GetComponent<MeshRenderer>();
        meshRendererBt = GetComponent<MeshRenderer>();
    }

   public void AcidOut()
    {
        meshRendererBt.material.SetFloat("_Fill", 0.32f);
    }

    public void AcidIn()
    {
        meshRendererCf.material.SetFloat("_Fill", 0.31f);
    }

    public void TitrationColorChange()
    {
        meshRendererCf.material.SetColor("_SideColor", Color.magenta);

    }
}
