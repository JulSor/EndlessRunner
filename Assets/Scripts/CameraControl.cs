using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour 
{

    public GameObject player;

    public Vector3 offset;

    // Use this for initialization
    void Start () 
    {
        offset = transform.position - player.transform.position + new Vector3(1.0f, 0.0f, 0.0f);
    }
	
	// Update is called once per frame
	void Update () 
    {
        transform.position = new Vector3(0.0f, player.transform.position.y, player.transform.position.z) + offset;
    }
}
