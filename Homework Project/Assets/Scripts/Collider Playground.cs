using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderPlayground : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
  
  
    }

    private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag ==  "Pillar") 
            {
                Debug.LogWarning("Player has hit a Pillar");
            }
           
            Color randomlySelectedColor = GetRandomColor(); 
            GetComponent<Renderer>().material.color = randomlySelectedColor;
        }

     private void OnCollisionStay(Collision collision)
        {
        
        }

    private void OnCollisionExit(Collision collision)
        {
             Debug.Log("Player has stopped collision");
        }

    private Color GetRandomColor()
    {
        return new Color(
            r:UnityEngine.Random.Range(0f, 1f),
            g:UnityEngine.Random.Range(0f, 1f),
            b:UnityEngine.Random.Range(0f, 1f));
    }
}
