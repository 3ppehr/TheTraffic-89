using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Controlling : MonoBehaviour
{
    public Manager0 Manager;
    public GameObject gameover;
    public int Health = 4;
    bool Heart1;
    bool Heart2;
    bool Heart3;
    public float speed;
    public float speed1;
    public Controlling playerscript;
    //Floating point variable to store the player's movement speed.

    private Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.

    // Use this for initialization
    void Start()
    {
        //Get and store a reference to the Rigidbody2D component so that we can access it.
        rb2d = GetComponent<Rigidbody2D>();
    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {
        

        if (Health <= 0)
       
            //gameover.SetActive(true);
            Manager.EndGame();
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
            rb2d.AddForce(movement * speed);
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
        }
    }
    public void Right()
    {
        if (Manager0.gamehasended == false && pausemenu.Gameispause == false)
        {
            rb2d.velocity = new Vector2(speed1, 0);
        }
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