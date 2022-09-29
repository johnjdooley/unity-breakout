using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    GameController gameController;
    AudioSource sound;

    void Start()
    {
        sound = GetComponent<AudioSource>();
        gameController = GameObject.FindWithTag("GameController").GetComponent<GameController>();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        sound.Play();
        gameController.LoseLife();
    }
}
