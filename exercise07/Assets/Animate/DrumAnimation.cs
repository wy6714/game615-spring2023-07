using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrumAnimation : MonoBehaviour
{
    public AudioSource drumSound;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Animator>().SetTrigger("DrumPlay");
            drumSound.Play();

        }
    }
}
