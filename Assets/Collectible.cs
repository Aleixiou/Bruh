using System;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    [SerializeField] private int value;
    private bool hasTriggered;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("blabla");
        if(collision.CompareTag("Player") && !hasTriggered)
        {
            hasTriggered = true;
            //Score
            Destroy(gameObject);
        }
    }
}