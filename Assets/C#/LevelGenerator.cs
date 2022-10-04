
using Assets.C_.SO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject[] SectorPrebafs;
    public GameObject[] EatPrebafs;

    public Save Save;
    public Game Game;
    

    
    public float DistanseBetweenSectors;
    public float DistanseBetweenEat;
    public Transform FinishSector;

    private const string sectorCountKey = "sectorKey";
    public int sectorsCount
    {
        get => PlayerPrefs.GetInt(sectorCountKey, 3);
        private set
        {
            PlayerPrefs.SetInt(sectorCountKey, value);
        }
    }


    


    private void Start()
    {

        

        for (int i = 0; i < sectorsCount; i++)
        {
            int prefabIndex = Random.Range(0, SectorPrebafs.Length);
            GameObject sector = Instantiate(SectorPrebafs[prefabIndex], transform);
            sector.transform.localPosition = CalculateSectorPosition(i);
            sector.transform.localRotation = Quaternion.Euler(0, 0, 0);
            
        }
        
        for (int i = 0; i < sectorsCount; i++)
        {
            int prefabIndexEat = Random.Range(0, EatPrebafs.Length);
            Vector3 position = new Vector3(DistanseBetweenEat * i, 0, 0);
            Quaternion rotation = Quaternion.Euler(0, 0, 0);

            Instantiate(EatPrebafs[prefabIndexEat], position, rotation, transform);

        }
        
        FinishSector.localPosition = CalculateSectorPosition(sectorsCount);
        

    }

    private Vector3 CalculateSectorPosition(int sectorIndex)
    {
        return new Vector3(DistanseBetweenSectors * sectorIndex, 0,0);
    }

    public void SectorCountPlus()
    {
        if (Game._currentLevelIndex > 0)
           sectorsCount++; 

    }

    public void SectorNuul()
    {
        PlayerPrefs.DeleteKey(sectorCountKey);
    }
}
