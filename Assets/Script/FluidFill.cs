using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FluidFill : MonoBehaviour
{
    public MeshRenderer meshRenderer;
    public MeshRenderer meshRenderer2;

    //public Material fluidMaterial;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer2 = GetComponent<MeshRenderer>();


    }

    public void ReduceFluid()
    {
        meshRenderer.material.SetFloat("_Fill", 0.7f);
    }
}
