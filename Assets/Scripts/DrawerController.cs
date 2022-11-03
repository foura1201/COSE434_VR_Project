using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;
using Valve.VR;
using System;

public class DrawerController : MonoBehaviour
{
    public bool locked;
    private bool drawerIn = true;
    private bool rotated = false;
    private bool hoverOn = false;

    public bool translate;
    public bool rotate;
    public float xT;
    public float yT;
    public float zT;
    public int xR;
    public int yR;
    public int zR;
    //public GameObject obj;

    Vector3 objPosition, rotation;
    public SteamVR_Action_Boolean GrabPinch;
    public SteamVR_Input_Sources handType1;
    public SteamVR_Input_Sources handType2;
    // Start is called before the first frame update
    void Start()
    {
        GrabPinch.AddOnStateDownListener(ButtonDown, handType1);
        GrabPinch.AddOnStateDownListener(ButtonDown, handType2);
        //objPosition = obj.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonDown(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        if (!locked)
        {
            if (hoverOn == true)
            {
                if (translate)
                {
                    if (drawerIn)
                    {
                        transform.Translate(0.0f, 0.0f, zT);
                        drawerIn = false;
                    }
                    else
                    {
                        transform.Translate(0.0f, 0.0f, -zT);
                        //transform.position = objPosition;
                        drawerIn = true;
                    }
                }

                if (rotate)
                {
                    if (rotated == false)
                    {
                        transform.Rotate(xR, yR, zR);
                        rotated = true;
                    }
                    else
                    {
                        transform.Rotate(-xR, -yR, -zR);
                        rotated = false;
                    }
                }
            }
        }
    }
    private void OnHandHoverBegin(Hand hand)
    {
        hoverOn = true;
    }

    private void OnHandHoverEnd(Hand hand)
    {
        hoverOn = false;
    }

    public void OpenLock()
    {
        locked = false;
    }
}
