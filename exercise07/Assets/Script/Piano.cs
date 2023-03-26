using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piano : MonoBehaviour
{
    //re
    public AudioSource reSound;
    public Animator reanim;
    //mi
    public AudioSource miSound;
    public Animator mianim;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //re
        if (Input.GetKeyDown(KeyCode.S))
        {
            reanim.SetTrigger("notePlay");
            reSound.Play();
        }

        //mi
        if (Input.GetKeyDown(KeyCode.D))
        {
            mianim.SetTrigger("notePlay");
            miSound.Play();
        }
    }
}
