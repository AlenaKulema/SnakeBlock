using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBody : MonoBehaviour
{
    
    public float Speed;


    public Vector3 lastTarget;
    public GameObject lastTargetOb;


    public Control PlayerMain;


    private void Start()
    {
        PlayerMain = GameObject.FindGameObjectWithTag("PlayerMain").GetComponent<Control>();
        Speed = 5;
        lastTargetOb = PlayerMain.Body[PlayerMain.Body.Count - 2];
        

    }

    private void Update()
    {

        lastTarget = lastTargetOb.transform.position;
        
        transform.LookAt(lastTarget);
        transform.position = Vector3.Lerp(transform.position, lastTarget, Time.deltaTime * Speed);
        
    }

    
}
