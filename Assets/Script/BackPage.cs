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
    //public Button NextButton;
    //public Button BackButton;

    public void BackToPaper1()
    {
        paper1.SetActive(true);
        paper2.SetActive(false);
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
}
