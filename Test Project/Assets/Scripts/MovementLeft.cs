using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementLeft : MonoBehaviour
{

    public float speed = 1;
    public bool moving = true;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // var position = this.transform.position;
        // position.x += Time.deltaTime * speed;
        // this.transform.position = position;
/*
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");
        
        this.transform.position += new Vector3(Time.deltaTime * xInput*speed, Time.deltaTime * yInput*speed, 0);
        
        */
        if (moving)
        {
            this.transform.position += new Vector3(Time.deltaTime * 1*speed, Time.deltaTime * 0*speed, 0);     
        }
       

    }
    
    private void OnTriggerEnter(Collider other)
    {
        //this.speed = speed * -4;
        //colorPicker = Random.Range(0, 10);
    }



    private void OnCollisionEnter2D(Collision2D other)
    {
        
        //if (other.collider.GetComponent<MovementLeft>())

        if (other.gameObject.tag == "PlayerRight")
        {
            var mr = other.collider.GetComponent<MovementRight>();
            this.moving = false;
            mr.moving = false;
            //saving mit wem kollidiert ist, damit nachher wieder bei Zerstörung fortgesetzt werden kann
            //+ use prefab, damit jedes Objekt einzeln behandelt wird, keine Kopie erstellen von einem char
            // der sich nicht bewegen darf
            
        }
            
        
       // this.speed = speed * -4;
       //if (other.collider. == )
        throw new NotImplementedException();
    }
}
