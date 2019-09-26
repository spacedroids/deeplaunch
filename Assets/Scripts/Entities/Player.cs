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
        speed += 10;
        //rigidbody.velocity = new Vector3(0, 10, 0);
        rigidbody.velocity = transform.forward * 10;
    }
}
