using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public Rigidbody Player;
    public float Senstivity;
    public float Speed = 500f;
    public List <GameObject> Body = new List <GameObject>();
    public GameObject bodyPrefab;
    public float Distans = 0.5f;

    private Vector3 _previousMpusePosition;

    



    private void Start()
    {
        Body.Add(gameObject);
    }
    void Update()
    {
        Player.AddForce(Speed * Time.deltaTime, 0, 0);
        if (Input.GetMouseButton(0))
        {
            Vector3 delta = Input.mousePosition - _previousMpusePosition;
            Player.AddForce(Speed * Time.deltaTime, 0, -delta.x * Senstivity);

        }
        _previousMpusePosition = Input.mousePosition;
    }


    public void BodyAdd()
    {
        

        Vector3 newLastPosition = Body[Body.Count-1].transform.position;
        newLastPosition.x -= Distans;

        Body.Add(GameObject.Instantiate(bodyPrefab, newLastPosition, Quaternion.identity) as GameObject);
    }
}

   
