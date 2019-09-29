using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float MAXHEALTH = 100f;

    public float speed;
    public float health;

    private Rigidbody rigidbody;

    public void Start()
    {
        health = MAXHEALTH;
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //Space friction
        rigidbody.velocity *= .999f;
        speed = rigidbody.velocity.magnitude;
    }

    public void Thrust() {
        rigidbody.velocity += transform.forward * 5;
    }
}
