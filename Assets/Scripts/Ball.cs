using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rb;
    AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.isKinematic = true;
        sound = GetComponent<AudioSource>();
    }

    public void launch(){
        rb.isKinematic = false;
        rb.AddRelativeForce(new Vector2(6, 20), ForceMode2D.Impulse);
    }

    public void disable(){
        rb.isKinematic = true;
        rb.velocity = Vector2.zero;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        sound.Play();
    }
}
