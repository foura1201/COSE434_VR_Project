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


    // Start is called before the first frame update
    void Start()
    {
        scrolls = scrollsManager.GetComponent<Scrolls>();
        SelectButton();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter");
        scrolls.currentUsingMagic = magicType;
        SelectButton();
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
        Debug.Log("HoverOn");
        scrolls.currentUsingMagic = magicType;
        SelectButton();
    }
}