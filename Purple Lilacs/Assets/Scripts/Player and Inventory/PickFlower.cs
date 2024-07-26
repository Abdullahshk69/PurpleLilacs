using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class pickFlower : MonoBehaviour
{
    //Value of 1 flower
    private int flowerValue = 1;
    [SerializeField] private GameObject finishObj;
    Finish finish;
    private void Start()
    {
        finish = finishObj.GetComponent<Finish>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            IInventory inventory = collision.GetComponent<IInventory>();

            if (inventory != null)
            {
                inventory inv = collision.GetComponent<inventory>();
                inventory.Flower = inventory.Flower + flowerValue;
                inv.PickUp();
                inv.PickupAudio();

                finish.CheckFlowers();
                Destroy(gameObject);
            }
        }
    }
}
