using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

public class BGMChange : MonoBehaviour
{
    public AudioClip success;
    private AudioSource AudioSource;
    // Start is called before the first frame update
    void Start()
    {
        AudioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeMusic()
    {
        AudioSource.Stop();
        AudioSource.clip = success;
        AudioSource.Play();
    }
}
