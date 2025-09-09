using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    void Start()
    {
        //empty
    }
    public float speed = 5f;


    void Update()
    {
        movChar();
        jumpFeat();
    }
    void movChar()//this moves player//
    { 
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(h, 0, v);
            transform.Translate(move * speed * Time.deltaTime);
    }
    void jumpFeat()//this makes the player jump//
    {
        Vector3 move = Vector3.zero;

        if (Input.GetKey(KeyCode.Space))
        {
            move += Vector3.up;
        }
         transform.position += Vector3.up * Time.deltaTime;
    }
}
