using Assets.C_.SO;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public Control Control;
    
    public UIManager UIManager;
    public LevelGenerator LevelGenerator;
    [SerializeField] private LevelList _levelList;
    public Save save;
    public int _currentLevelIndex;

   

    private void Awake()
    {
        
        _currentLevelIndex = save.GetLevelIndex();
        _currentLevelIndex %= _levelList.Levels.Length;
        Player.HP = 100;
        Player.Score = save.GetScore();

        
        if (_currentLevelIndex == 0)
        {
            save.SaveLevel(_currentLevelIndex);
            Player.Score = 0;
            LevelGenerator.SectorNuul();
        }
        Instantiate(_levelList.Levels[_currentLevelIndex]);
    }

    public enum State
    {
        Playing,
        Won,
        Loss,

    }

    public State CurrentState { get; private set; }

    


    public void OnPlayerDied()
    {
        if (CurrentState != State.Playing) return;

        CurrentState = State.Loss;
        Control.enabled = false;
        UIManager.Game();
        UIManager.Lose();
        
    }

    public void OnPlayerFinish()
    {
        if (CurrentState != State.Playing) return;
        CurrentState = State.Won;
        Control.enabled = false;
       
        _currentLevelIndex++;
        save.SaveLevel(_currentLevelIndex);

        

        UIManager.Game();
        UIManager.Win();
    }


    public void LoadNextLevel()
    {

        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

   
    public void Restart()
    {
        
        _currentLevelIndex--;
        save.SaveLevel(_currentLevelIndex);
    }


    public void Score()
    {
        save.SaveScore(Player.Score);
        LevelGenerator.SectorCountPlus();

    }
}
