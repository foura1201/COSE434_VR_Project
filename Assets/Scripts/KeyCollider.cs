using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollider : MonoBehaviour
{
    public GameObject key;
    public GameObject leftdoor;
    public GameObject rightdoor;
    public GameObject Padlock;
    public GameObject successTrigger;
    private STrigger sTrigger;
    private DrawerController drawerController1;
    private DrawerController drawerController2;

    public bool keyActive = false;
    // Start is called before the first frame update
    void Start()
    {
        drawerController1 = leftdoor.GetComponent<DrawerController>();
        drawerController2 = rightdoor.GetComponent<DrawerController>();
        sTrigger = successTrigger.GetComponent<STrigger>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = key.transform.position;
        gameObject.transform.position = position;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        Debug.Log(keyActive);
        if(other.gameObject.name == "Padlock" && keyActive)
        {
            drawerController1.OpenLock();
            drawerController2.OpenLock();
            //Debug.Log("hasOpened");
            Padlock.SetActive(false);
            sTrigger.GameEnd();
        }
    }

    public void setKey()
    {
        keyActive = true;
    }
}
