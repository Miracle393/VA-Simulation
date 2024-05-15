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

    public void BackToMolesHydrogen()
    {
        MolesHydrogen.SetActive(true);
        Finish.SetActive(false);
    }
    public void BackToMoleNaOH()
    {
        MoleNaOH.SetActive(true);
        MolesHydrogen.SetActive(false);
    }
    public void BackToMoleHcl()
    {
        MoleHcl.SetActive(true);
        MoleNaOH.SetActive(false);
    }
    public void BackToCalculateConcentrationBII()
    {
        CalculateConcentrationBII.SetActive(true);
        MoleHcl.SetActive(false);
    }
    public void BackToCalculateConcentrationBI()
    {
        CalculateConcentrationBI.SetActive(true);
        CalculateConcentrationBII.SetActive(false);
    }
    public void BackToCalculateConcentrationA()
    {
        CalculateConcentrationA.SetActive(true);
        CalculateConcentrationBI.SetActive(false);
    }
    public void BackToCalculateConvert()
    {
        CalculateConvert.SetActive(true);
        CalculateConcentrationA.SetActive(false);
    }
    public void BackToResultTable()
    {
        ResultTable.SetActive(true);
        CalculateConvert.SetActive(false);
    }
    public void BackToPaper2Remind()
    {
        paper2Remind.SetActive(true);
        ResultTable.SetActive(false);
    }
    public void BackToHeadOut()
    {
        HeadOut.SetActive(true);
        paper2Remind.SetActive(false);
    }
    public void BackToRefillBurette()
    {
        RefillBurette.SetActive(true);
        HeadOut.SetActive(false);
    }

    public void BackToEmptyConicalFlask()
    {
        EmptyConicalFlask.SetActive(true);
        RefillBurette.SetActive(false);
    }

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
