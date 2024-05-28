using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{       
    private int speed = 50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "prepatstvie") 
        {
            Destroy(gameObject);
        }
    }
}
