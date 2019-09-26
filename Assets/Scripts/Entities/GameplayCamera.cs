using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayCamera : MonoBehaviour
{
    private Vector3 playerOffset;

    void Start()
    {
        //Init the player offset based on the camera as positioned manually in the scene
        playerOffset = transform.position;
    }

    void Update()
    {
        transform.position = GameController.Instance.gpsm.player.transform.position + playerOffset;
    }
}
