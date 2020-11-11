using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour
{

    public float moveSpeed = 1;
    public float rotateSpeed = 180;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");
        
    //    transform.Translate(transform.forward * Time.deltaTime * moveSpeed * yInput, Space.World);
        
        transform.Rotate(transform.up, rotateSpeed*Time.deltaTime*xInput);
      //  transform.
        
    }
}
