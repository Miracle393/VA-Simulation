using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextPage : MonoBehaviour
{
    public GameObject paper1;
    public GameObject paper2;
    //public Button NextButton;
    //public Button BackButton;

    public void NextPaper()
    {
        paper1.SetActive(false);
        paper2.SetActive(true);
    }
}
