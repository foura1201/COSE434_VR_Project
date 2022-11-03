using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakJug : MonoBehaviour
{
    private int life = 3;

    public GameObject garlicCollider;
    public GameObject garlic;
    private float time = 0;
    private bool crackLock = false;

    public GameObject JarBreak;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = JarBreak.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(crackLock)
        {
            time += Time.deltaTime;
            if(time>1)
            {
                time = 0;
                crackLock = false;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Contains("Stone") && !crackLock)
        {
            //jug shake animation?
            life--;
            crackLock = true;
            audioSource.Play();
            //collision.gameObject.SetActive(false);
        }
        if (life < 0)
        {
            gameObject.SetActive(false);
            garlic.GetComponent<Rigidbody>().useGravity = true;
            garlicCollider.SetActive(true);
        }
    }
}
