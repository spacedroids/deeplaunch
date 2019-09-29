using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplaySceneManager : MonoBehaviour
{
    public InGameState currentState;

    public InGameState inGameState_Play;
    public InGameState inGameState_Pause;

    //UI Canvases
    public GameObject pauseCanvas;
    public GameObject gamePlayCanvas;
    //UI Elements
    public Text playerSpeedTelemetry;

    //Gameplay entities
    public Player player;

    //State flags
    public bool pauseButtonPressed;
    public bool unPauseButtonPressed;
    public bool quitButtonPressed;

    private void InstantiateInGameStates()
    {
        inGameState_Play = new InGameState_Play();
        inGameState_Pause = new InGameState_Pause();
    }

    public void Awake()
    {
        GameController.Instance.gpsm = this;
    }

    void Start()
    {
        //Hack to ensure GameController is instantiated if Gameplay scene is loaded directly from Unity SDK
        if(GameController.Instance) { }
        //Instantiate state classes
        InstantiateInGameStates();
        //Start in play state
        currentState = inGameState_Play;
        currentState.enterState(this);

        player = GameObject.Find("PlayerShip").GetComponent<Player>();
    }

    void Update()
    {
        playerSpeedTelemetry.text = player.speed.ToString();
    }

    public void PauseButtonClick()
    {
        pauseButtonPressed = true;
    }

    public void UnPauseButtonClick()
    {
        unPauseButtonPressed = true;
    }

    public void QuitButtonClick() {
        quitButtonPressed = true;
    }
}
