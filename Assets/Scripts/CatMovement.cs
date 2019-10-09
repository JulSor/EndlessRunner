using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMovement : MonoBehaviour 
{
    public Rigidbody cat_Rigidbody;

    public Animator anim;

    public GameObject cat;

    public Transform catPos;

    public GameObject ocean;

    public Transform leftTarget;
    public Transform rightTarget;
    
    public float speed = 8;


    // Use this for initialization
    public void Start () 
    {
        cat_Rigidbody = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        anim.speed = 1.3f;
    }
	
	// Update is called once per frame
	public void Update () 
    {
        anim.Play("Run");

        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        ocean.transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if (catPos.position.x > -1.5 && Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position = transform.position + new Vector3(-2, 0, 0);
        }
        /*if (catPos.position.x < 0.5f && catPos.position.x > -0.5 && Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = transform.position + new Vector3(-2, 0, 0);
        }*/
        

        if (catPos.position.x < 1.5 && Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position = transform.position + new Vector3(2, 0, 0);
        }
        /*if (catPos.position.x > -0.5 && catPos.position.x < 0.5 && Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = transform.position + new Vector3(2, 0, 0);
        }*/
    }
}
