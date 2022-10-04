using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject panelWin;
    public GameObject panelLose;
    public GameObject panelGame;



    public void Win()
    {
        panelWin.SetActive(true);
    }


    public void Lose()
    {
        panelLose.SetActive(true);
    }

    public void Game()
    {
        panelGame.SetActive(false);
    }

}
