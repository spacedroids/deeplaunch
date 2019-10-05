using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Ship
{
    public float MAXHEALTH = 100f;

    public float speed;

    public override void Update()
    {
        //Space friction
        _rigidbody.velocity *= .999f;
        speed = _rigidbody.velocity.magnitude;
        base.Update();
    }

    public void Thrust() {
        _rigidbody.velocity += transform.forward * 5;
    }
}
