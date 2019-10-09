using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPlatMover : MonoBehaviour 
{

    public Vector3 newPlatStartPosition;

    /*public Tran
    public float speed;*/

	// Use this for initialization
	public void Start () 
    {
        newPlatStartPosition = transform.position;
        //newPosition = transform.position;
    }
	
	// Update is called once per frame
	public void Update () 
    {
        /*float step = speed * Time.deltaTime;

        transform.position = Vector3.MoveTowards(transform.position, target.position, step);*/

    }
}
