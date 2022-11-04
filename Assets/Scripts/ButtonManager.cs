using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class ButtonManager : MonoBehaviour
{
    public int magicType;
    public Button button;

    public GameObject scrollsManager;
    private Scrolls scrolls;

    private bool hoverOn = false;

    public SteamVR_Action_Boolean GrabPinch;
    public SteamVR_Input_Sources handType1;

    // Start is called before the first frame update
    void Start()
    {
        GrabPinch.AddOnStateDownListener(ButtonDown, handType1);
        scrolls = scrollsManager.GetComponent<Scrolls>();
        SelectButton();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectButton()
    {
        if (scrolls.currentUsingMagic == magicType)
        {
            EventSystem.current.SetSelectedGameObject(null);
            button.Select();
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

    private void ButtonDown(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        if (hoverOn)
        {
            scrolls.currentUsingMagic = magicType;
            SelectButton();
        }
    }
}