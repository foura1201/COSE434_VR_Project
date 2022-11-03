using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicController : MonoBehaviour
{
    public GameObject Button0;
    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;
    public GameObject Button4;

    public GameObject scrollsManager;
    private Scrolls scrolls;

    // Start is called before the first frame update
    void Awake()
    {
        scrolls = scrollsManager.GetComponent<Scrolls>();

        Button0.SetActive(scrolls.magics[0]);
        Button1.SetActive(scrolls.magics[1]);
        Button2.SetActive(scrolls.magics[2]);
        Button3.SetActive(scrolls.magics[3]);
        Button4.SetActive(scrolls.magics[4]);
        
    }

    void OnEnable()
    {
        Button0.SetActive(scrolls.magics[0]);
        Button1.SetActive(scrolls.magics[1]);
        Button2.SetActive(scrolls.magics[2]);
        Button3.SetActive(scrolls.magics[3]);
        Button4.SetActive(scrolls.magics[4]);

        /*MagicButton.SetActive(true);
        LightButton.SetActive(true);
        OpenButton.SetActive(true);
        ChangeButton.SetActive(true);
        TransparentButton.SetActive(true);*/
    }

    // Update is called once per frame
    void Update()
    {

    }
}