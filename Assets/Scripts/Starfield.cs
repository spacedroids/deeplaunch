
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

/**
* Copied from http://guidohenkel.com/2018/05/endless_starfield_unity/
*/

public class Starfield : MonoBehaviour
{
    ParticleSystem particles;
    ParticleSystem.MainModule mainParticles;

    void Awake()
    {
        //Stars = new ParticleSystem.Particle[MaxStars];
        particles = GetComponent<ParticleSystem>();
        Assert.IsNotNull(particles, "Particle system missing from object!");
        mainParticles = particles.main;
    }

    void Start()
    {

    }

    void Update()
    {
        //float starSpeed = Mathf.Max(GameController.Instance.gpsm.player.speed, 0.1f);
        //mainParticles.startSpeed = starSpeed;
    }
}
