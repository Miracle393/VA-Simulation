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
}
