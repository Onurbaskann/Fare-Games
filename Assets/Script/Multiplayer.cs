using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Multiplayer : NetworkBehaviour
{
    public Transform heroObj;   
    void Start()
    {

    }
    void FixedUpdate()
    {
        if (!isLocalPlayer)
        {
            return;
        }
        if (Input.GetKey("w"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 2);
            heroObj.transform.eulerAngles = new Vector3(0, 0, 90);
        }
        else if (Input.GetKey("s"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, -2);
            heroObj.transform.eulerAngles = new Vector3(0, 0, -90);
        }
        else if (Input.GetKey("a"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-2, 0);
            heroObj.transform.eulerAngles = new Vector3(0, 0, 180);
        }
        else if (Input.GetKey("d"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(2, 0);
            heroObj.transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
    }

}

