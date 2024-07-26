using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructablePlatformTrigger : MonoBehaviour
{
    BoxCollider2D boxCollider;
    DestructablePlatform destructablePlatform;
    private void Start()
    {
        boxCollider = transform.parent.GetComponent<BoxCollider2D>();
        destructablePlatform = transform.parent.GetComponent<DestructablePlatform>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (boxCollider.enabled == true)
        {
            if (collision.gameObject.name == "Bell")
            {
                destructablePlatform.CoroutineCaller();
            }
        }
    }
}
