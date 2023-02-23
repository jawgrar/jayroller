using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollusion : MonoBehaviour
{
    public Rigidbody rigidBody;
    public float upForce;
    public float backwardForce;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            rigidBody.AddForce(0, upForce, -backwardForce, ForceMode.Impulse);
        }
    }
}
