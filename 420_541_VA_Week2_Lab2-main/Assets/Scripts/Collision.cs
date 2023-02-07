using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public float pushForce = 10.0f;

        private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Rigidbody playerRigidbody = other.gameObject.GetComponent<Rigidbody>();
            Vector3 pushDirection = (playerRigidbody.position - transform.position).normalized;
            playerRigidbody.AddForce(pushDirection * pushForce, ForceMode.Impulse);
        }
    }


}

