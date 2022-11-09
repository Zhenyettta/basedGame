using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Walk speed")]
    public float speed = 3f;

    [Header("Run speed")]
    public float ranSpeed = 5f;

    [Header("Jump power")]
    public float jumpPower = 200f;
    private float jumpControle = 0.75f;

    [Header("is on the Ground")]
    public bool ground;
    public bool readyToJump = true;

    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetImput();
    }

    private void GetImput()
    {

        if (Input.GetKey(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.localPosition += transform.forward * ranSpeed * Time.deltaTime;
            }
            else
            {
                transform.localPosition += transform.forward * speed * Time.deltaTime;
            }

        }

        if (Input.GetKey(KeyCode.S))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.localPosition += -transform.forward * ranSpeed * Time.deltaTime;
            }
            else
            {
                transform.localPosition += -transform.forward * speed * Time.deltaTime;
            }
        }

        if (Input.GetKey(KeyCode.A))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.localPosition += -transform.right * ranSpeed * Time.deltaTime;
            }
            else
            {
                transform.localPosition += -transform.right * speed * Time.deltaTime;
            }
        }

        if (Input.GetKey(KeyCode.D))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.localPosition += transform.right * ranSpeed * Time.deltaTime;
            }
            else
            {
                transform.localPosition += transform.right * speed * Time.deltaTime;
            }
        }

  




        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (ground == true && readyToJump)
            {
                readyToJump = false;

                rb.AddForce(transform.up * jumpPower);


                Invoke(nameof(ResetJump), jumpControle);
            }
        }
    }



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            ground = true;
        }
        else
        {
            ground = false;
        }
    }

    private void ResetJump()
    {
        readyToJump = true;
    }
}