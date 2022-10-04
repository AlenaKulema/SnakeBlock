using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBody : MonoBehaviour
{
    public GameObject Body;
    
    public float DistanseBetweenBody;
    internal static int body = 0;

    public void InstantiateBody()
    {
        Vector3 position = new Vector3(DistanseBetweenBody, 0, 0);
        Quaternion rotation = Quaternion.Euler(0, 0, 0);
        Instantiate(Body, position, rotation, transform);
    }


    



    

    
}
