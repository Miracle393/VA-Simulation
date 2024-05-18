using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialMenu : MonoBehaviour
{
    public GameObject WelcomeBoard;
    public GameObject MovementBoard;
    public GameObject MovementBoardII;
    public GameObject InteractionBoard;

    public void HideAllBoard()
    {
        WelcomeBoard.SetActive(false);
        MovementBoard.SetActive(false);
        MovementBoardII.SetActive(false);
        InteractionBoard.SetActive(false); 
    }
    
    public void EnterMovementBoard()
    {
        //WelcomeBoard.SetActive(false);
        HideAllBoard();
        MovementBoard.SetActive(true);
    }

    public void EnterMovementBoardII()
    {
        //MovementBoard.SetActive(false);
        HideAllBoard();
        MovementBoardII.SetActive(true);
    }

    public void EnterInteractionBoard()
    {
        HideAllBoard();
        InteractionBoard.SetActive(true);
    }

    public void BackMovementBoard()
    {
        HideAllBoard();
        MovementBoard.SetActive(true);
    }

    public void BackHome()
    {
        HideAllBoard();
        WelcomeBoard.SetActive(true);
    }
}
