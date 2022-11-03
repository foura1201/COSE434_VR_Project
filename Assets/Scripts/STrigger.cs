using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class STrigger : MonoBehaviour
{
    public GameObject Player;
    public GameObject Success;
    private BGMChange BGMChange;
    // Start is called before the first frame update
    void Start()
    {
        BGMChange = Player.GetComponent<BGMChange>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void GameEnd()
    {
        BGMChange.ChangeMusic();
        Success.SetActive(true);
    }
}
