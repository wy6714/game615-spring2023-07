using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterController cc;
    public Animator PlayerAnim;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        transform.Rotate(0, 80 * x * Time.deltaTime, 0);

        if (x != 0 || y != 0)
        {
            PlayerAnim.SetBool("isWalking", true);
        }
        else
        {
            PlayerAnim.SetBool("isWalking", false);
        }

        cc.Move(transform.forward * y * Time.deltaTime * 5);

    }
}
