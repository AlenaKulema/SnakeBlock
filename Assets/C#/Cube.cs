using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public bool Evil;
    public bool Light;
    public Material EvilMaterial;
    public Material LightMaterial;
    public Material Material;
    public TMPro.TMP_Text Text;
    private UnityEngine.Object explosion;
    private UnityEngine.Object explosion2;
    private UnityEngine.Object explosion3;


    public Collision eat;

    private void Start()
    {
        explosion = Resources.Load("Explosion"); 
        explosion2= Resources.Load("Explosion2");
        explosion3= Resources.Load("Explosion3");
    }

    private void Awake()
    {
        GetComponent<Renderer>().sharedMaterial = Evil ? EvilMaterial : Light ? LightMaterial : Material;
        if (Evil)Text.text = "30".ToString();
        
        else if (Light) Text.text = "5".ToString();

        else Text.text="15".ToString();
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.collider.TryGetComponent(out Player player))
        {
            return;
        }
        player.CubeExplosion();
        if (Player.HP <= 0)
        {
            return;
        }
        else if (Evil)
        {
            Explosion(explosion3);
            if (Player.HP < 30)
            {
                Player.HP -= Player.HP;
                Destroy(gameObject);
            }
            else
            {
                Player.HP -= 30;
                Destroy(gameObject);
            }
                
        }


        else if (Light)
        {
            Explosion(explosion);
            if (Player.HP < 5)
            {
                Player.HP -= Player.HP;
                

                Destroy(gameObject);
            }
            else
            {
                Player.HP -= 5;
                
                Destroy(gameObject);
            }

        }
        else
        {
            Explosion(explosion2);
            if (Player.HP < 15)
            {
                Player.HP -= Player.HP;
                Destroy(gameObject);
            }
            else
            {
                Player.HP -= 15;
                Destroy(gameObject);
            }

        }
        
    }
    private void Explosion(UnityEngine.Object @object)
    {
        GameObject explosion1ref = (GameObject)Instantiate(@object);
        explosion1ref.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }
}
