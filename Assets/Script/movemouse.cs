using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movemouse : MonoBehaviour
{
    public Transform heroObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey("w"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2 (0,2);
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
