using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    internal static int HP=100;
    internal static int Score;
    public Sector CurrentSector;
    public Game Game;
    public Audio Audio;
    
   

    public TMPro.TMP_Text TextHP;
    public TMPro.TMP_Text TextScore;
    public TMPro.TMP_Text UITextScore;
    public TMPro.TMP_Text LevelNumber;
    public TMPro.TMP_Text LevelNumberGame;



    private void Start()
    {
        LevelNumber.text = "Level " + (Game._currentLevelIndex + 1) + " passed".ToString();
        LevelNumberGame.text = "LEVEL " + (Game._currentLevelIndex + 1).ToString();
    }


    public void ReachFinish()
    {
        Game.OnPlayerFinish();
    }

    // Update is called once per frame
    void Update()
    {
        
        TextHP.text = HP.ToString();
        TextScore.text = Score.ToString();
        UITextScore.text = TextScore.text;


        if (HP <= 0)
            Game.OnPlayerDied();
        

    }

    public void FoodEat()
    {
        Audio.FoodAudio();
    }
    public void CubeExplosion()
    {
        Audio.CubeAudio();
    }
}
