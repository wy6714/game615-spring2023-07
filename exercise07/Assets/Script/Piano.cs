using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piano : MonoBehaviour
{
    //do
    public AudioSource doSound;
    public Animator doanim;
    //re
    public AudioSource reSound;
    public Animator reanim;
    //mi
    public AudioSource miSound;
    public Animator mianim;
    //fa
    public AudioSource faSound;
    public Animator faanim;
    //sol
    public AudioSource solSound;
    public Animator solanim;
    //la
    public AudioSource laSound;
    public Animator laanim;
    //si
    public AudioSource siSound;
    public Animator sianim;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //do
        if (Input.GetKeyDown(KeyCode.A))
        {
            doanim.SetTrigger("notePlay");
            doSound.Play();
        }
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
        //fa
        if (Input.GetKeyDown(KeyCode.F))
        {
            faanim.SetTrigger("notePlay");
            faSound.Play();
        }
        //sol
        if (Input.GetKeyDown(KeyCode.G))
        {
            solanim.SetTrigger("notePlay");
            solSound.Play();
        }
        //la
        if (Input.GetKeyDown(KeyCode.H))
        {
            laanim.SetTrigger("notePlay");
            laSound.Play();
        }
        //si
        if (Input.GetKeyDown(KeyCode.J))
        {
            sianim.SetTrigger("notePlay");
            siSound.Play();
        }
    }
}
