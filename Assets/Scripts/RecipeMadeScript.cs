using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecipeMadeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("startingtorotate");
        //StartCoroutine("RotateForSecs", 500000.00f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*IEnumerator RotateForSecs(float second)
    {
        float speed = 10.0f;
        while (second > 0)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * speed);
            second -= Time.deltaT ime;
        }

        yield break;
    }*/
}
