using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeakEnemy : EnemyShip
{
    public override void Start()
    {
        maxHealth = 1;
        shieldHealth = 0;
        shieldsUp = false;
        explosionScale = 0.2f;

        base.Start();
    }
}