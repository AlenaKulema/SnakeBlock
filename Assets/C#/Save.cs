using UnityEngine;

public class Save : MonoBehaviour
{
    private const string LevelIndexKey = "LevelIndex";
    


    public void SaveLevel(int levelIndex)
    {
        PlayerPrefs.SetInt(LevelIndexKey, levelIndex);
    }

    public int GetLevelIndex()
    {
        return PlayerPrefs.GetInt(LevelIndexKey, 0);
    }


    private const string ScoreKey = "ScoreKey";

    public void SaveScore(int ScoreIndex)
    {
        PlayerPrefs.SetInt(ScoreKey, ScoreIndex);
    }

    public int GetScore()
    {
        return PlayerPrefs.GetInt(ScoreKey, 0);
    }

    private const string SectorsCountKey = "SectorsCount";
    public void SaveSectorCount(int SectorCount)
    {
        PlayerPrefs.SetInt(SectorsCountKey, SectorCount);
    }

    public int GetSectorsCount()
    {
        return PlayerPrefs.GetInt(SectorsCountKey, 0);
    }
}
