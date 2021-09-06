using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text zmn;
    // Start is called before the first frame update
    void Start()
    {
        zmn.text = "TİME: "+ PlayerPrefs.GetString("point");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
