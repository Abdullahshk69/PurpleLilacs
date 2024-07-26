using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator animator;
    private PlayerMovement playerMovement;
    private GameObject checkpoint;
    public AudioSource audio;

    private void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        playerMovement = GetComponent<PlayerMovement>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Trap"))
        {
            Die();
        }
    }

    public void Die()
    {
        audio.Play(); //BAAAA X_X
        rb.bodyType = RigidbodyType2D.Static;
        animator.SetTrigger("death");
        playerMovement.enabled = false;
        Invoke(nameof(RestartCheckpoint), 2.0f);
    }

    private void RestartCheckpoint()
    {
        animator.SetTrigger("respawn");
        // Allowing player to move again
        playerMovement.enabled = true;
        rb.bodyType=RigidbodyType2D.Dynamic;

        // Respawning at the checkpoint's position
        rb.transform.position = checkpoint.transform.position;
        Invoke(nameof(ResetTrigger), 0.1f);
        
    }

    private void ResetTrigger()
    {
        animator.ResetTrigger("respawn");
    }

    public void setCheckpoint(GameObject gameObject)
    {
        checkpoint = gameObject;
    }
}
