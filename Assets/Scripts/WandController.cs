using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;
using Valve.VR;

public class WandController : MonoBehaviour
{

    public bool grabWand = false;
    private bool hoverOn = false;

    public SteamVR_Action_Boolean GrabPinch;
    public SteamVR_Input_Sources handType1;
    // Start is called before the first frame update
    void Start()
    {
        GrabPinch.AddOnStateDownListener(ButtonDown, handType1);
        GrabPinch.AddOnStateUpListener(ButtonUp, handType1);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ButtonDown(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        //Debug.Log(hoverOn);
        if (hoverOn)
        {
            grabWand = true;
        }
    }

    public void ButtonUp(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        grabWand = false;
        hoverOn = false;
    }

    private void OnHandHoverBegin(Hand hand)
    { 
        hoverOn = true;
    }
}
