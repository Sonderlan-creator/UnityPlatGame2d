using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPlayer : MonoBehaviour
{

    public float Velocidade;
    public float ForcaPulo;

    private Rigidbody2D rig;
    private bool Pulando;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        rig.velocity = new Vector2(Velocidade, rig.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space) && !Pulando)
        {
            rig.AddForce(Vector2.up * ForcaPulo, ForceMode2D.Impulse);
            Pulando = true;


        }
    }


    void OnCollisionEnter2D(Collision2D colisor)
    {
        if (colisor.gameObject.layer == 8)
        {
            {
                Pulando = false;


            }


        }
    }
}
