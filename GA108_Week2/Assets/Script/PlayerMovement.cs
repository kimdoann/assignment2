using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A : MonoBehaviour
{
    public float speed = 5f;

    void Update()//this moves player//
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Debug.Log("Test");
        Vector3 move = new Vector3(h, 0, v);
            transform.Translate(move * speed * Time.deltaTime);
    }
}
