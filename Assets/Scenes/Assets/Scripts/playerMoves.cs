using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMoves : MonoBehaviour
{
    public playerController_2D controller;
    public float runSpeed = 40f;
    public Animator animator;
    private float timeLeft = 3;
    public GameObject plant;
    public GameObject flaque;
    public GameObject planche;

    float horizontalMove = 0f;
    bool climb = false;
    //bool crouch = false;
    int score = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            climb = true;
            animator.SetBool("isClimbing", true);
        }
        timeLeft -= Time.deltaTime;


        if (plant.activeSelf == false && timeLeft < 0)
        {
            plant.SetActive(true);
            timeLeft = 3;
        }
        else if (flaque.activeSelf == false && timeLeft < 0)
        {
            flaque.SetActive(true);
            timeLeft = 3;
        }
        else if (planche.activeSelf == false && timeLeft < 0)
        {
            planche.SetActive(true);
            timeLeft = 3;
        }
        //if (Input.GetButtonDown("Crouch"))
        //{
        //crouch = true;
        //} else if (Input.GetButtonUp("Crouch"))
        //{
        //crouch = false;
        //}
    }

    public void OnLanding()
    {
        animator.SetBool("isClimbing", false);
    }

    void FixedUpdate ()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, climb);
        climb = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //Check the provided Collider2D parameter other to see if it is tagged "PickUp", if it is...
        if (other.gameObject.name == "plantemechante" || other.gameObject.name == "flacdeau" || other.gameObject.name =="planchecasser")
        {
            score += 1;
            Debug.Log("score =" + score);
            other.gameObject.SetActive(false);
        }
        //Debug.Log("touche");
 

        if (other.gameObject.name == "chest")
        {
            /*if (score != 0)
            {
                Application.Quit();
                Debug.Log("coffre");
            }*/
            //winText.text = "You win !";
        }
    }
}
