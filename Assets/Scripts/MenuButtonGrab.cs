using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;
using Valve.VR;
using Valve.VR.InteractionSystem;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
//using UnitySceneManager = UnityEngine.SceneManagement.SceneManager;

public class MenuButtonGrab : MonoBehaviour
{
    private bool hoverOn = false;
    public bool isQuit;

    public SteamVR_Action_Boolean GrabPinch;
    public SteamVR_Input_Sources handType1;

    // Start is called before the first frame update
    void Start()
    {
        GrabPinch.AddOnStateDownListener(ButtonDown, handType1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnHandHoverBegin(Hand hand)
    {
        hoverOn = true;
    }

    private void OnHandHoverEnd(Hand hand)
    {
        hoverOn = false;
    }

    private void ButtonDown(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        if (hoverOn)
        {
            if (isQuit)
            {
                Application.Quit();
            }
        }
    }

}


