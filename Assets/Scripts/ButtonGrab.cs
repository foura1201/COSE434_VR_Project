using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class ButtonGrab : MonoBehaviour
{
    private bool hoverOn = false;
    public GameObject input;
    private KeyPadInput KeyPadInput;

    public char num;
    public bool isNum;
    public bool isReset;
    public bool isEnter;

    public SteamVR_Action_Boolean GrabPinch;
    public SteamVR_Input_Sources handType1;

    // Start is called before the first frame update
    void Start()
    {
        GrabPinch.AddOnStateDownListener(ButtonDown, handType1);
        KeyPadInput = input.GetComponent<KeyPadInput>();
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
            if (isNum)
            {
                KeyPadInput.numberButton(num);
            }
            if(isReset)
            {
                KeyPadInput.resetButton();
            }
            if(isEnter)
            {
                KeyPadInput.enterButton();
            }
        }
    }
}
