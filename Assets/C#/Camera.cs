using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Player Player;
    public Vector3 SectorToCameraOffset;
    public float Speed;
    
    void Update()
    {
        if (Player.CurrentSector == null) return;

        Vector3 targetPosition = Player.CurrentSector.transform.position + SectorToCameraOffset;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, Speed * Time.deltaTime);
    }
    

   
}
