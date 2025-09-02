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


    void Update()//this moves player//
    {
    }
    void MovChar()
    { 
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(h, 0, v);
            transform.Translate(move * speed * Time.deltaTime);
    }
    void JumpFeat()
    {


    }
