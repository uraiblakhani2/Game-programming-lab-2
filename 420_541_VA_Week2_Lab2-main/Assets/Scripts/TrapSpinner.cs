using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapSpinner : MonoBehaviour
{
    public float spinSpeed = 15.0f;
    private Vector3 rotation;


    // Start is called before the first frame update
    void Start()
    {
        rotation = Vector3.up * spinSpeed;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(0, spinSpeed * Time.deltaTime, 0);

    }
}


