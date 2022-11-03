using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Scrolls : MonoBehaviour
{
    public static int totalScrolls = 5;
    public bool[] magics = new bool[totalScrolls];
    public int currentHoverScroll = totalScrolls;
    public int currentUsingMagic = totalScrolls;

    // Start is called before the first frame update
    void Awake()
    {
        for(int i=0; i< totalScrolls; i++)
        {
            magics[i] = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void getScroll(int num)
    {
        magics[num] = true;
        currentUsingMagic = num;
        currentHoverScroll = totalScrolls;
    }
}
