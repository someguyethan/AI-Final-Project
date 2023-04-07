using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;

public class Player : MonoBehaviour
{
    //Movement
    public float jumpForce;
    public float minSpeed;
    public float maxSpeed;
    public float currentSpeed;
    public float offset;
    public bool isGrounded = false;
    public Rigidbody2D rb;

    public Text text;

    //Animations
    public Animator anim;

    void Awake()
    {
        currentSpeed = minSpeed;
    }
    void Update()
    {
        //Move right
        gameObject.transform.Translate(Vector3.right * Time.deltaTime * currentSpeed * offset);
        //If space bar is pushed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Only jump if on the ground (prevents jumping in air)
            if (isGrounded)
            {
                rb.AddForce(Vector2.up * jumpForce);
                isGrounded = false;
                anim.SetBool("isGrounded", false);
            }
        }
        //Increase speed slowly
        currentSpeed += Time.deltaTime * 0.1f;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //If on the ground
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            anim.SetBool("isGrounded", true);
        }
        //If you hit a spike
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            if (this.gameObject.name == "Player")
            {
                text.text = "You Lose";
                Time.timeScale = 0;
                anim.SetBool("isDead", true);
            }
            if (this.gameObject.name == "Ghost")
            {
                text.text = "You Win";
                Time.timeScale = 0;
            }
        }
    }
}
