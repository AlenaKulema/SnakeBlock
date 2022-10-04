using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eat : MonoBehaviour
{
    


    
    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.collider.TryGetComponent(out Player player)) return;
        player.FoodEat();
        Player.Score += 50;


        player.GetComponent<Control>().BodyAdd();
        Destroy(gameObject);
    }
}


    
