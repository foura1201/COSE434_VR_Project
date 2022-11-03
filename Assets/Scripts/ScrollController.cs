using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class ScrollController : MonoBehaviour
{
    public GameObject scrollsManager;
    private Scrolls scrolls;

    public int scrollNum;

    // Start is called before the first frame update
    void Start()
    {
        scrolls = scrollsManager.GetComponent<Scrolls>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnHandHoverBegin(Hand hand)
    {
        scrolls.currentHoverScroll = scrollNum;
    }

    private void OnHandHoverEnd(Hand hand)
    {
        scrolls.currentHoverScroll = 5;
    }

}
