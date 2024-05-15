using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextPage : MonoBehaviour
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

    public void NextPaper()
    {
        paper1.SetActive(false);
        paper2.SetActive(true);
    }

    public void ToAddBase()
    {
        paper2 .SetActive(false);
        AddBase.SetActive(true);
    }

    public void ToAddIndicator()
    {
        AddBase.SetActive(false);
        AddIndicator.SetActive(true);
    }

    public void ToTitrationControl()
    {
        AddIndicator.SetActive(false);
        TitrationControl.SetActive(true);
    }

    public void ToEmptyConicalFlask()
    {
        TitrationControl.SetActive(false);
        EmptyConicalFlask.SetActive(true);
    }

    public void ToRefillBurette()
    {
        EmptyConicalFlask.SetActive(false);
        RefillBurette.SetActive(true);
    }

    public void ToTitrationControlII()
    {
        RefillBurette.SetActive(false);
        TitrationControlII.SetActive(true);
    }

    public void ToTitrationControlIII()
    {
        RefillBurette.SetActive(false);
        TitrationControlIII.SetActive(true);
    }

    public void ToHeadOut()
    {
        RefillBurette.SetActive(false);
        HeadOut.SetActive(true);
    }

    public void ToPaper2Remind()
    {
        HeadOut.SetActive(false);
        paper2Remind.SetActive(true);
    }

    public void ToResultTable()
    {
        paper2Remind.SetActive(false);
        ResultTable.SetActive(true);
    }

    public void ToCalculateConvert()
    {
        ResultTable.SetActive(false);
        CalculateConvert.SetActive(true);
    }

    public void ToCalculateConcentrationA()
    {
        CalculateConvert.SetActive(false);
        CalculateConcentrationA.SetActive(true);
    }

    public void ToCalculateConcentrationBI()
    {
        CalculateConcentrationA.SetActive(false);
        CalculateConcentrationBI.SetActive(true);
    }

    public void ToCalculateConcentrationBII()
    {
        CalculateConcentrationBI.SetActive(false);
        CalculateConcentrationBII.SetActive(true);  
    }

    public void ToCalculateMoleHcl()
    {
        CalculateConcentrationBII.SetActive(false);
        MoleHcl.SetActive(true);
    }
    
    public void ToMoleNaOH()
    {
        MoleHcl.SetActive(false);
        MoleNaOH.SetActive(true);
    }

    public void ToMolesHydrogen()
    {
        MoleNaOH.SetActive(false);
        MolesHydrogen.SetActive(true);
    }

    public void ToFinish()
    {
        MolesHydrogen.SetActive(false);
        Finish.SetActive(true);
    }
}
