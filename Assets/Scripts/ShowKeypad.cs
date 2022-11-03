using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;
using Valve.VR;

public class ShowKeypad : MonoBehaviour
{
    public GameObject button;
    private bool activity = false;
    private bool hoverOn = false;

    public SteamVR_Action_Boolean GrabPinch;
    public SteamVR_Input_Sources handType1;
    // Start is called before the first frame update
    void Start()
    {
        button.SetActive(false);
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
        if(hoverOn)
        {
            activity = !activity;
            button.SetActive(activity);
        }
    }
}
