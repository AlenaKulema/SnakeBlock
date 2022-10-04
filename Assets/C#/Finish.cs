using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public Player Player;
    private void OnTriggerEnter(Collider other)
        {
        if (other.CompareTag("PlayerMain"))
        {

            Player.ReachFinish();
        }

        
        

        
    }
}

