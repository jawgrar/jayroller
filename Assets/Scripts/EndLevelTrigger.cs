using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevelTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // check if the player has collided with the end level trigger
        if (other.CompareTag("Player"))
        {
            FindObjectOfType<GameManager>().CompleteLevel();
        }
    }
}
