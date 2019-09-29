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
        
    }

    public void Thrust() {
        rigidbody.velocity += transform.forward * 5;
        speed = rigidbody.velocity.magnitude;
    }
}
