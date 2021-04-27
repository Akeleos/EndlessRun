using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Controller : MonoBehaviour
{

    private Rigidbody theRB; //initialize rigidbody
    public float jumpForce = 0; // force of jump
    public bool GroundCheck = true; //checking ground to 
    public Vector3 gravityValue = Physics.gravity * 3 ; // gravity modify

    private Animator anim;
    private Renderer rend;

    //conditions goes here
    public bool gameOver = false;
    public bool won = false;

    //some ui elements smiling there
    public Text scoreText;
    private int score = 0;

    public GameObject winPanel;
    //public GameObject losePanel;


    // Start is called before the first frame update
    void Start()
    {
        theRB = GetComponent<Rigidbody>();
        Physics.gravity = gravityValue;
        anim = GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
        
        //lets make some noise. thats allow you to jump with space. addition, you can jump by touching left side of your phone..
        if (Input.GetKeyDown(KeyCode.Space) && GroundCheck)
        {
            theRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            GroundCheck = false;
            anim.SetTrigger("JumpTrigger");
            
        }
    }
    
    public void GameOver()
    {
        if(gameOver == false)
        {
            gameOver = true;
            anim.SetTrigger("Death");
            Debug.Log("Game Over!");
            
        }
        
        
       
    }
    
    public void Won()
    {
        if(scoreText.text == "1000")
        {
            won = true;
            anim.SetTrigger("Victory");
            Debug.Log("You Won!");
            winPanel.SetActive(true);
            
        }
        else
        {
            winPanel.SetActive(false);
        }

        
    }


    public void Scored()
    {
        if (gameOver)
        {
            return;
        }
        score += 100;
        scoreText.text = score.ToString();
    }


    private void OnTriggerEnter(Collider other)
    {
            Scored();
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Ground"))
        {
            GroundCheck = true;
        }
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            GameOver();

        }
        else
        {
            Won();
        }
        
    }
}
