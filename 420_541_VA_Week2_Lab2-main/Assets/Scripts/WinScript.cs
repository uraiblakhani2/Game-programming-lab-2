using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScript : MonoBehaviour
{

    private void OnTriggerEnter(Collider collider)
    {
        {
            Debug.Log("You Win");
        }
    }
}