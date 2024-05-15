using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ExitChemLab : MonoBehaviour
{
    public void ExitLab()
    {
        SceneManager.LoadScene("1 Start Scene");
    }

}
