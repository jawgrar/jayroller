using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    public new Rigidbody rigidbody;
    public float forwardForce = 500;
    public float sidewaysForce = 200;

    public KeyCode rightKey = KeyCode.D;
    public KeyCode leftKey = KeyCode.A;

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidbody.AddForce(0, 0, forwardForce * Time.deltaTime);

        #if UNITY_IOS

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = touch.position;

            if (touchPosition.x > Screen.width / 2)
            {
                rigidbody.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            else
            {
                rigidbody.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
        }

        #else

        if (Input.GetKey(rightKey))
        {
            rigidbody.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey(leftKey))
        {
            rigidbody.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        #endif
    }
}
