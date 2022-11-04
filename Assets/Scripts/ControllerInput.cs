using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using System;

public class ControllerInput : MonoBehaviour
{
    public SteamVR_Action_Boolean UseMagic;
    public SteamVR_Action_Boolean OpenMenu;
    public SteamVR_Action_Boolean GrabGrip;
    public SteamVR_Input_Sources handType;
    private static int distance = 3;

    public GameObject DoorLeft;
    public GameObject DoorRight;
    public GameObject Wand;
    public GameObject Player;
    private WandController wandController;
    private bool doorClosed = true;

    public GameObject mirrorTMP;
    private bool mirrorWrited = false;

    public GameObject wandLight;
    private bool lightOn = false;

    public GameObject hidePaper;
    private bool recipeSeen = false;

    public GameObject finalKey;
    public GameObject finalKey_s;
    public GameObject airTotem;
    public GameObject keyCollider;
    private KeyCollider KeyColliderSctipt;
    private bool hasTransform = false;

    public GameObject scrollerManager;
    private Scrolls scrolls;

    public GameObject Scroll0;
    public GameObject Scroll1;
    public GameObject Scroll2;
    public GameObject Scroll3;
    public GameObject Scroll4;

    private bool openedMenu = false;
    public GameObject MagicMenu;

    public GameObject MagicUse;
    private AudioSource audioSourceMagicUse;

    // Start is called before the first frame update
    void Start()
    {
        UseMagic.AddOnStateDownListener(ButtonDown, handType);

        OpenMenu.AddOnStateDownListener(OpenMenuButtonDown, handType);

        GrabGrip.AddOnStateDownListener(GetScrollButtonDown, handType);

        wandController = Wand.GetComponent<WandController>();
        scrolls = scrollerManager.GetComponent<Scrolls>();
        KeyColliderSctipt = keyCollider.GetComponent<KeyCollider>();
        audioSourceMagicUse = MagicUse.GetComponent<AudioSource>();

        mirrorTMP.SetActive(mirrorWrited);
        wandLight.SetActive(lightOn);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonDown(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        /*Debug.Log("wand");
        Debug.Log(wandController.grabWand);
        Debug.Log("door");
        Debug.Log(doorClosed);
        Debug.Log("magic");
        Debug.Log(scrolls.magics[0]);*/

        if (wandController.grabWand == true && doorClosed == true && scrolls.currentUsingMagic==0) //wand는 오른손에 들고 x key를 눌러야 가능
        {
            float dist = Vector3.Distance(DoorLeft.transform.position, Player.transform.position);
            if (dist < distance)
            {
                DoorLeft.transform.Rotate(0, 90, 0);
                DoorRight.transform.Rotate(0, -90, 0);
                doorClosed = false;
                audioSourceMagicUse.Play();
            }
        }
        if (wandController.grabWand == true && !mirrorWrited && scrolls.currentUsingMagic == 1) //wand는 오른손에 들고 x key를 눌러야 가능
        {
            float dist = Vector3.Distance(mirrorTMP.transform.position, Player.transform.position);
            if (dist < distance)
            {
                mirrorTMP.SetActive(true);
                mirrorWrited = true;
                audioSourceMagicUse.Play();
            }
        }

        if(wandController.grabWand == true && scrolls.currentUsingMagic == 2)
        {
            lightOn = !lightOn;
            if (lightOn)
            {
                wandLight.SetActive(true);
                audioSourceMagicUse.Play();
            }
            else
            {
                wandLight.SetActive(false);
                audioSourceMagicUse.Play();
            }
        }

        if (wandController.grabWand == true && !recipeSeen && scrolls.currentUsingMagic == 3) //wand는 오른손에 들고 x key를 눌러야 가능
        {
            float dist = Vector3.Distance(hidePaper.transform.position, Player.transform.position);
            if (dist < distance)
            {
                hidePaper.SetActive(false);
                recipeSeen = true;
                audioSourceMagicUse.Play();
            }
        }

        if (wandController.grabWand == true && !hasTransform && scrolls.currentUsingMagic == 4) //wand는 오른손에 들고 x key를 눌러야 가능
        {
            float dist = Vector3.Distance(airTotem.transform.position, Player.transform.position);
            if (dist < distance)
            {
                finalKey_s.SetActive(false);
                airTotem.SetActive(false);
                finalKey.SetActive(true);
                hasTransform = true;
                KeyColliderSctipt.setKey();
                audioSourceMagicUse.Play();
            }
        }
    }

    public void OpenMenuButtonDown(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        openedMenu = !openedMenu;
        if (openedMenu)
        {
            MagicMenu.SetActive(true);
        }
        else
        {
            MagicMenu.SetActive(false);
        }
    }

    public void GetScrollButtonDown(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        if (scrolls.currentHoverScroll == 0)
            Scroll0.SetActive(false);
        else if (scrolls.currentHoverScroll == 1)
            Scroll1.SetActive(false);
        else if (scrolls.currentHoverScroll == 2)
            Scroll2.SetActive(false);
        else if (scrolls.currentHoverScroll == 3)
            Scroll3.SetActive(false);
        else if (scrolls.currentHoverScroll == 4)
            Scroll4.SetActive(false);

        if (scrolls.currentHoverScroll < 5)
            scrolls.getScroll(scrolls.currentHoverScroll);
    }
}
