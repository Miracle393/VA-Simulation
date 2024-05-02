using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FluidFill : MonoBehaviour
{
    public Material fluidMaterial;

    public void ReduceFluid()
    {
        fluidMaterial.SetFloat("_Fill", 0.6f);
    }
}
