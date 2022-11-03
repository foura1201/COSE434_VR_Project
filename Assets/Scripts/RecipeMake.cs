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
            //����..???
        }
    }

    public void GenerateScroll()
    {
        ScrollObject.SetActive(true);
        //3�ʰ� �����鼭 ȸ���ϴٰ� ���߿� ���߱�
        //RigidBody �� �ָ� �� ��..? rigidbody �� �ְ� ���ڸ����� ������ ȸ���ϰ� �غ���
        //ScrollObject.SetActivate(false);
    }
}
