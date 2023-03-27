using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class playerController : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterController cc;
    public Animator PlayerAnim;

    //battery bar
    public float battery = 1;
    public Image batteryImage;
    public Animator batteryAnim;

    //go to music land
    public bool batteryReady = false;
    public Animator gardenAnim;
    public GameObject Road;
    //gameObject road = Road;
    //public TextMeshProUGUI batteryText;
    void Start()
    {



        //Road.SetActive(false);
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

        //check if battery enough
        if (battery >= 90)
        {
            batteryReady = true;
        }
        else
        {
            batteryReady = false;
        }
        //battery enough, move to music land
        if (batteryReady == true)
        {
            gardenAnim.SetTrigger("gardenMove");

            //set player position to (1.6,4.71,15.6)
            transform.position = new Vector3(3.3f, 0f, -4.3f);
            //Vector3(-3.5,-4.40999699,0)
            //Road.SetActive(true);
        }


    }

    //if player collide with battery, then battery will be destroyed
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("battery"))
        {
            Destroy(other.gameObject);
            battery = battery + 30;
            //batteryText = battery.ToString();
            batteryImage.fillAmount = battery / 90;
            batteryAnim.SetTrigger("ShowMenu");
        }
    }
}
