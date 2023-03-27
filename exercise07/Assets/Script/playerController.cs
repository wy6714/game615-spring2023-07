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
    //public TextMeshProUGUI batteryText;
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
