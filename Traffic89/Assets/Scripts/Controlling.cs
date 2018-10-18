using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Controlling : MonoBehaviour
{
    Rigidbody2D rd;
    public Manager0 Manager;
    public Animator myanimator;
    public GameObject gameover;
    public int Health = 4;
    bool Heart1;
    bool Heart2;
    bool Heart3;
    public float speed;
    float dirX;
    public float speed1;
    public Controlling playerscript;
    //Floating point variable to store the player's movement speed.

     Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.

    // Use this for initialization
    void Start()
    {
        //Get and store a reference to the Rigidbody2D component so that we can access it.
        rb2d = GetComponent<Rigidbody2D>();
        rd = GetComponent<Rigidbody2D>();
        myanimator = GetComponent<Animator>();
    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void Update()
    {
        if (Manager0.gamehasended == false && pausemenu.Gameispause == false)
        {


            dirX = Input.acceleration.x * speed1;
            transform.position = new Vector2(Mathf.Clamp(transform.position.x, -7.5f, 7.5f), transform.position.y);
        }

        }
    void FixedUpdate()
    {
        rd.velocity = new Vector2(dirX, 0f);
    
        if (Health <= 0)
        {
            //gameover.SetActive(true);
            Manager.EndGame();
        }
           
        else {

            if (Manager0.gamehasended == false && pausemenu.Gameispause == false)
            {


                
            //Store the current horizontal input in the float moveHorizontal.
            float moveHorizontal = Input.GetAxis("Horizontal");

            //Store the current vertical input in the float moveVertical.
            float moveVertical = Input.GetAxis("Vertical");

            //Use the two store floats to create a new Vector2 variable movement.
            Vector2 movement = new Vector2(moveHorizontal, moveVertical);

            //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
            //rb2d.AddForce(movement * speed);
        }
        }
    }


    public Vector2 CurrentInput
    {
        get
        {
            return new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        }
    }




    public void left()
    {
        if (Manager0.gamehasended == false && pausemenu.Gameispause == false)
        {
            rb2d.velocity = new Vector2(-speed1, 0);
            myanimator.SetBool("Left", true);
        }
    }
    public void Right()
    {
        if (Manager0.gamehasended == false && pausemenu.Gameispause == false)
        {
            rb2d.velocity = new Vector2(speed1, 0);
            myanimator.SetBool("Right", true);

        }
    }
    public void reset()
    {
        myanimator.SetBool("Right", false);
        myanimator.SetBool("Left", false);
    }

    public void up()
    {
        if (Manager0.gamehasended == false && pausemenu.Gameispause == false)
        {
            rb2d.velocity = new Vector2(0, speed1);
        }
    }

    public void set()
    {
        rb2d.velocity = Vector2.zero;

    }


   

    public void Damagetoplayer()
    {
        //bool tmp = EnemyInRange();

        playerscript.Health -= 1;
        //Debug.Log(playerscript.Health);

    }


    
}