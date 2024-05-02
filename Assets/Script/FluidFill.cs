using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FluidFill : MonoBehaviour
{
    public MeshRenderer meshRenderer1;
    public MeshRenderer meshRenderer2;

    //public Material fluidMaterial;

    void Start()
    {
        meshRenderer1 = GetComponent<MeshRenderer>();
        meshRenderer2 = GetComponent<MeshRenderer>();


    }

    public void ReduceFluid()
    {
        Debug.Log("Test Button");
        meshRenderer1.material.SetFloat("_Fill", 0.7f);
        meshRenderer2.material.SetFloat("_Fill", 0.5f);
    }
}
