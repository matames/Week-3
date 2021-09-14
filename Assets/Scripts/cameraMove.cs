using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("I hit something");
           // if(collision.gameObject.name == "Circle 2")
           // {
           //     Vector3 newCamPos = new Vector3(collision.gameObject.transform.position.x, collision.gameObject.transform.position.y, -10);
             //   Camera.main.transform.position = newCamPos;

           // }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "CamPos1")
           {
              Vector3 newCamPos = new Vector3(collision.gameObject.transform.position.x, collision.gameObject.transform.position.y, -10);
              Camera.main.transform.position = newCamPos;

            }
    }

}
