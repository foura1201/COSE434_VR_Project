using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PaperWrite : MonoBehaviour
{
    public GameObject TMP;
    // Start is called before the first frame update
    void Start()
    {
        TMP.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Quill2")
        {
            TMP.SetActive(true);
        }
    }
}
