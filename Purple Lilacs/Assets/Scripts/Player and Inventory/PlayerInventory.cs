using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class inventory : MonoBehaviour, IInventory
{
    public int Flower { get => _flower; set => _flower = value; }

    public int _flower = 0;
    int totalFlowers;

    [SerializeField] private TextMeshProUGUI lilacTxt;
    [SerializeField] private GameObject totalFlowersInALevel;
    public AudioSource audio;

    private void Start()
    {
        PickUp();
        totalFlowers=totalFlowersInALevel.GetComponent<CountFlowers>().GetFlowers();
    }
    public void PickUp()
    {
        lilacTxt.text = _flower.ToString();
    }
    public void PickupAudio()
    {
        audio.Play();
    }
}
