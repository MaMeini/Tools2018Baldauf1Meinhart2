using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour
{

    public GameObject monsterLeft;
    public GameObject monsterRight
        ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnMonsterLeft()
    {
        var position = new Vector3(
            -2.5f,  //x
            5.7f,  //y
            0); //z

        GameObject created = GameObject.Instantiate(monsterLeft, position, Quaternion.identity);

        Debug.Log("spawned an object", created);
    }
    
    public void SpawnMonsterLeftU()
    {
        var position = new Vector3(
            -2.5f,  //x
            2.5f,  //y
            0); //z

        GameObject created = GameObject.Instantiate(monsterLeft, position, Quaternion.identity);

        Debug.Log("spawned an object", created);
    }
    
    public void SpawnMonsterRight()
    {
        var position = new Vector3(
            1.0f,  //x
            2.5f,  //y
            0); //z

        GameObject created = GameObject.Instantiate(monsterRight, position, Quaternion.identity);
        created.transform.Rotate(0.0f, 0.0f, 0.0f, Space.World);
//created.SetActive();
        Debug.Log("spawned an object", created);
    }
    public void SpawnMonsterRightU()
    {
        var position = new Vector3(
            1.0f,  //x
            -0.68f,  //y
            0); //z

        GameObject created = GameObject.Instantiate(monsterRight, position, Quaternion.identity);
        created.transform.Rotate(0.0f, 0.0f, 0.0f, Space.World);

        Debug.Log("spawned an object", created);
    }
}
