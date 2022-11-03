using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class KeyPadInput : MonoBehaviour
{
    public TextMeshPro TextMeshPro;
    public string answer;

    public static int totalDrawers;

    public GameObject drawer;
    private DrawerController DrawerController;
    public GameObject keypad;
    // Start is called before the first frame update
    void Start()
    {
        TextMeshPro.text = "";
        DrawerController = drawer.GetComponent<DrawerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void numberButton(char num)
    {
        if (TextMeshPro.text.Length < 4)
        {
            TextMeshPro.text += num;
        }
    }

    public void resetButton()
    {
        TextMeshPro.text = "";
    }

    public void enterButton()
    {
        if(TextMeshPro.text == answer)
        {
            DrawerController.OpenLock();
            Debug.Log(DrawerController.locked);
            keypad.SetActive(false);

        }
        else
        {
            TextMeshPro.text = "WRONG";
        }
    }
}
