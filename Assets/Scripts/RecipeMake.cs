using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using System;

public class RecipeMake : MonoBehaviour
{
    bool putApple = false;
    bool putPear = false;
    bool putGarlic = false;

    public GameObject ScrollObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Contains("Recipe"))
        {
            if (collision.gameObject.name == "Apple")
                putApple = true;
            else if (collision.gameObject.name == "Pear")
                putPear = true;
            else if (collision.gameObject.name == "Garlic")
                putGarlic = true;
            
            if (putApple && putGarlic && putPear)
            {
                GenerateScroll();
            }
        }
        else
        {
            //뱉어내기..???
        }
    }

    public void GenerateScroll()
    {
        ScrollObject.SetActive(true);
        //3초간 빛나면서 회전하다가 공중에 멈추기
        //RigidBody 안 주면 될 듯..? rigidbody 안 주고 제자리에서 빛나며 회전하게 해보자
        //ScrollObject.SetActivate(false);
    }
}
