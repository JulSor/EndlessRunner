using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollSize : MonoBehaviour
{

    public MeshCollider m_Collider;
    Vector3 m_Size;
    // Start is called before the first frame update
    void Start()
    {
        //Fetch the Collider from the GameObject
        m_Collider = GetComponent<MeshCollider>();

        //Fetch the size of the Collider volume
        m_Size = m_Collider.bounds.size;

        //Output to the console the size of the Collider volume
        Debug.Log("Collider Size : " + m_Size);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
