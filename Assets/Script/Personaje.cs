using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Personaje : MonoBehaviour
{
    ControlaJuego cj;
    Rigidboody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixUpdate()
    {
        if (cj)
        {
            if (cj.jugando)
            {
                if (Input.GetKey(KeyCode.W))
                {
                    rd.AddForce(Vecor2.up, ForceMode2D.Force);
                }
            }
        }
    }
}
