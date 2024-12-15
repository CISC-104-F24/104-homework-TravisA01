using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionObjects : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    
    }

    
    //3D Trigger Events
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Started");
    }

    private void OnTriggerStay(Collider other)
    {
       if (other.gameObject.tag == "Player") 
       {
            transform.position = new Vector3(7.8f, 0.52f, -15.93f);
       }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger Ended");
    }



}
