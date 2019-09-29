using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip : Ship
{
    public float shotFrequency = 0.5f;
    public TurretBattery turretBattery;
    private float sinceLastShot;
    public Player player;

    public override void Start()
    {
        player = GameController.Instance.gpsm.player;
        turretBattery = gameObject.GetComponentInChildren<TurretBattery>();
        base.Start();
    }

    public override void Update()
    {
        sinceLastShot += Time.deltaTime;
        if(sinceLastShot >= shotFrequency)
        {
            turretBattery.fire(player.transform.position);
            sinceLastShot = 0f;
        }
    }
}