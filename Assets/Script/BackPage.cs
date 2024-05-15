using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackPage : MonoBehaviour
{
    public GameObject paper1;
    public GameObject paper2;
    public GameObject AddBase;
    public GameObject AddIndicator;
    public GameObject TitrationControl;
    public GameObject EmptyConicalFlask;
    public GameObject RefillBurette;
    public GameObject TitrationControlII;
    public GameObject TitrationControlIII;
    public GameObject HeadOut;
    public GameObject paper2Remind;
    public GameObject ResultTable;
    public GameObject CalculateConvert;
    public GameObject CalculateConcentrationA;
    public GameObject CalculateConcentrationBI;
    public GameObject CalculateConcentrationBII;
    public GameObject MoleHcl;
    public GameObject MoleNaOH;
    public GameObject MolesHydrogen;
    public GameObject Finish;
    //public Button NextButton;
    //public Button BackButton;

   

   //public void BackTo Emp
    public void BackToTitrationControl()
    {
        TitrationControl.SetActive(true);
        EmptyConicalFlask.SetActive(false);
    }

    public void BackToAddIndicator()
    {
        AddIndicator.SetActive(true);
        TitrationControl.SetActive(false);
    }

    public void BackToAddBase()
    {
        AddBase.SetActive(true);
        AddIndicator.SetActive(false);
    }

    public void BackToPaper2()
    {
        paper2.SetActive(true);
        AddBase.SetActive(false);
    }

    public void BackToPaper1()
    {
        paper1.SetActive(true);
        paper2.SetActive(false);
    }
}
