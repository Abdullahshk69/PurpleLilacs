using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CountFlowers : MonoBehaviour
{
    private int totalFlowers;

    void Awake()
    {
        // Counts the amount of collectable flowers at start in a level
        totalFlowers = transform.childCount;
    }

    public int GetFlowers()
    {
        return totalFlowers;
    }
}
