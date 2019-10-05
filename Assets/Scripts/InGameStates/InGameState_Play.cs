using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameState_Play : InGameState
{
    public override void enterState(GameplaySceneManager gpsm, InGameState previousState = null)
    {
        Debug.Log("Entered (in-game) Play state.");

        //Should make sure pause menu is hidden on init
        gpsm.pauseCanvas.SetActive(false);
        gpsm.gamePlayCanvas.SetActive(true);

    }

    public override void doUpdate(GameplaySceneManager gpsm)
    {
        if(gpsm.pauseButtonPressed)
        {
            gpsm.pauseButtonPressed = false;
            changeState(gpsm.inGameState_Pause, gpsm);
        }
        gpsm.playerSpeedTelemetry.text = Mathf.Round(gpsm.player.speed).ToString();
        gpsm.playerDistanceTelemetry.text = Mathf.Round(gpsm.player.transform.position.z).ToString();

        if(Input.GetKeyDown("space"))
        {
            gpsm.player.Thrust();
        }

        if(Input.GetKeyDown("'")) {
            gpsm.player.Damage(1000, 1f);
        }
    }

}
