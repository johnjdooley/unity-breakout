using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = 2;


    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            transform.position += new Vector3(Input.GetAxis("Horizontal"), 0, 0) * Time.deltaTime * speed;

            if (transform.position.x >  6) transform.position = new Vector3(6, transform.position.y, 0);

            if (transform.position.x <  -6) transform.position = new Vector3(-6, transform.position.y, 0);
        }
    }
}
