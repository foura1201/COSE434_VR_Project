using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class DoorOpen : MonoBehaviour
{
    public GameObject Wand;
    private WandController wandController;
    private InputDevice targetDevice;

    // Start is called before the first frame update
    void Start()
    {
        //transform.Rotate(0, 90, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
