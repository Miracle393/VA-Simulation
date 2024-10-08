using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddBaseCf : MonoBehaviour
{
    public MeshRenderer meshRendererCf;
    public MeshRenderer meshRendererSb;
    public GameObject TitrationFluid;
    public Color AgainColor;

    // Start is called before the first frame update
    void Start()
    {
       // meshRendererCf = GetComponent<MeshRenderer>();
        meshRendererSb = GetComponent<MeshRenderer>();
    }

    public void BaseIn()
    {
       //to add XOH base into the conical flask, increase volume in conical flask
       // meshRendererCf.material.SetFloat("_Fill", 0.303f);
       TitrationFluid.SetActive(true);

        
    }
    public void BaseOut()
    {
        //to decrease the fluid in Soln B 
        meshRendererSb.material.SetFloat("_Fill", 0.535f);
    }

    public void ToWhiteColor()
    {
        meshRendererCf.material.color = AgainColor;

    }

}
