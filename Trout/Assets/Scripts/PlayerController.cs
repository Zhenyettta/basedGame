using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 3f;

    public float ranSpeed = 5f;

    public float jumpPower = 200f;

    private float jumpControle = 0.75f;

    public int health = 100;

    [Header("is on the Ground")]
    public bool ground;
    public bool readyToJump = true;
    public static bool isGameOver;


    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        GetImput();
        if(isGameOver)
        {
            //exit
        }
    }

    #region Movement

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
    #endregion

    #region Health update

    public float cooldown = 1f; //seconds
    private float lastAttackedAt = -9999f;

    public void TakeDamageFromEnemy(int damageFromEnemy)
    {
        health -= damageFromEnemy;

        print("Hit"); //animation
        //sound

        if (health <= 0)
        {
            print("My DEAR you are Dead");
            isGameOver = true;
        }
    }
    #endregion
}