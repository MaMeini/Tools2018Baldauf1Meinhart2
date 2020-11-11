using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementRight : MonoBehaviour
{
    public bool moving = true;
    public float speed = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (moving)
        {
            this.transform.position += new Vector3(Time.deltaTime * -1*speed, Time.deltaTime * 0*speed, 0);
        }
        
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.tag == "PlayerLeft")
        {
            var mr = other.collider.GetComponent<MovementLeft>();
            this.moving = false;
            mr.moving = false;
        }
        
        // this.speed = speed * -4;
        //if (other.collider. == )
        throw new NotImplementedException();
    }
}
