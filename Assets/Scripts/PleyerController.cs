using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PleyerController : MonoBehaviour
{
    [SerializeField] private GameObject bullet; 
    [SerializeField] private Transform bulletTransform;
    private Quaternion bulletRotation;

    
    
    public float sensitivity = 2;
    private float horizontal, vertical;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Mouse X") * sensitivity;
        vertical = Input.GetAxis("Mouse Y") * sensitivity;

        transform.Rotate(0, horizontal, 0);

        bulletRotation = Quaternion.Euler(bulletTransform.rotation.eulerAngles.x,bulletTransform.rotation.eulerAngles.y,0);

        if (Input.GetMouseButtonDown(0)){
            Instantiate(bullet, bulletTransform.position, bulletRotation);
        }
    }
}
