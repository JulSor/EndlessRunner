using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour {

    public PlatRecycler platRecycler;

    public void OnEnable()
    {
        platRecycler = GameObject.FindObjectOfType<PlatRecycler>();
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "cat")
        {
            Debug.Log("recycle trigger");
            platRecycler.RecyclePlatform(this.gameObject);
        }

    }
}
