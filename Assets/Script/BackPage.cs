using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackPage : MonoBehaviour
{
    public GameObject paper1;
    public GameObject paper2;
    //public Button NextButton;
    //public Button BackButton;

    public void BackPaper()
    {
        paper1.SetActive(true);
        paper2.SetActive(false);
    }
}
