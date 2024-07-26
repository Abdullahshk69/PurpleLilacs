using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    //Sound effect
    public AudioSource audio;

    bool firstTime = true;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (firstTime)
            {
                if (gameObject.CompareTag("Checkpoint"))
                {
                    audio.Play();
                    PlayerLife playerLife = collision.GetComponent<PlayerLife>();
                    playerLife.setCheckpoint(gameObject);
                }
                else if (gameObject.CompareTag("Checkpoint_Bean"))
                {

                }
                firstTime = false;
            }
        }
    }
}
