using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{

    public Rigidbody rb; 
    private Animator driver; //used to find character animator
    // Start is called before the first frame update
    //MY ACTION KEYS HERE:
    [SerializeField]
    private KeyCode jumpkey = KeyCode.Space;


    void Start()
    {
        var rb = GetComponent< Rigidbody > ();
        driver = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        MoveForward();
        Rotate();
        
    }

    void MoveForward()
    {
        if(Input.GetAxis("Vertical")>0f)
        {
            driver.SetBool("Walk", true);
            driver.SetFloat("Blend", Input.GetAxis("Fire3"));
            //Debug.Log(Input.GetAxis("Fire3"));
            if(Input.GetKeyDown(KeyCode.LeftControl))
            {
                driver.SetTrigger("roll");
            }

        }
        else
        {
            driver.SetBool("Walk", false);
        }
    }

    void Jump()
    {
        if (Input.GetKeyDown(jumpkey))
        {
            driver.SetTrigger("Jump");
        }
    }

    void Rotate()
    {
        transform.Rotate(Vector3.up, Input.GetAxis("Horizontal") * Time.deltaTime * 75f);
    }

    void FixedUpdate () //makes the player restart if they fall below a certain point (CAN BE DISABLED) 
    {
        if (rb.position.y < -4f)
        {
            FindObjectOfType<GameManager>().EndGame(); 
        }
    }

            
        
}
