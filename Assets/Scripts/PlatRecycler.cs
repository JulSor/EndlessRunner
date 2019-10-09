using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatRecycler : MonoBehaviour 
{
    [SerializeField]
    public GameObject[] platforms;
    [SerializeField]
    public float zedOffset;

    // Use this for initialization
    public void Start()
    {
        for (int i = 0; i < platforms.Length; i++)
        {
            Instantiate(platforms[i], new Vector3(0, 0, i * 96.2f), Quaternion.Euler(0,0,0));
            zedOffset += 96.2f;
        }
	}

    public void Update()
    {
        Debug.Log(zedOffset);
    }

    public void RecyclePlatform(GameObject platform)
    {
        platform.transform.position = new Vector3(0, 0, zedOffset);
        zedOffset += 96.2f;
    }
}
