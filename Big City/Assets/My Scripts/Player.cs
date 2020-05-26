using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Rigidbody rb;

    public float force;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.AddForce(Vector3.right * force * Input.GetAxis("Horizontal"), ForceMode.Force);
        rb.AddForce(Vector3.forward * force * Input.GetAxis("Vertical"), ForceMode.Force);
    }
}
