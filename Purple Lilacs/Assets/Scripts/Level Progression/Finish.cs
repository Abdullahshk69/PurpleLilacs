using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    [SerializeField] GameObject FlowersParent;
    [SerializeField] GameObject Player;
    inventory inv;
    private SpriteRenderer sprite;
    int totalFlowers;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        inv = Player.GetComponent<inventory>();
        totalFlowers = FlowersParent.GetComponent<CountFlowers>().GetFlowers();
        //sprite.enabled = false;
        gameObject.SetActive(false);
    }

    private bool CheckInventory()
    {
        return inv.Flower == totalFlowers;
    }

    public void CheckFlowers()
    {
        if (CheckInventory())
        {
            //sprite.enabled = true;
            gameObject.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (CheckInventory())
            {
                Rigidbody2D rb = collision.GetComponent<Rigidbody2D>();
                PlayerMovement playerMovement = collision.GetComponent<PlayerMovement>();
                Animator playerAnimator = collision.GetComponent<Animator>();
                int state = 0; // Idle Animation
                playerMovement.enabled = false;
                playerAnimator.SetInteger("state", state);
                rb.velocity = new Vector2(0, rb.velocity.y);
                Invoke(nameof(CompleteLevel), 1.0f);
            }
        }
    }

    private void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
