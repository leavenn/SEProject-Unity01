using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float obstSpeed = 30f;
    private Rigidbody obstRb;

    void Start()
    {
        obstRb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        obstRb.velocity = new Vector3(0, 0, -obstSpeed);
    }

    private void Update()
    {
        if (transform.position.z < -10f)
        {
            Destroy(gameObject);
        }
    }
}
