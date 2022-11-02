using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Швидкість руху персонажа")]
    public float speed = 7f;

    [Header("Швидкість бігу персонажа")]
    public float ranSpeed = 20f;

    [Header("Сила стрибка")]
    public float jumpPower = 200f;

    [Header("Ми на землі?")]
    public bool ground;

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
            if(ground == true)
            {
                rb.AddForce(transform.up * jumpPower);
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            ground = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            ground = false;
        }
    }
}
