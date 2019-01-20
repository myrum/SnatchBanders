using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leScripty : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((transform != null) && Input.GetKey("right"))
        {
            transform.Rotate(0, (float).5, 0);
        }

        if ((transform != null) && Input.GetKey("left"))
        {
            transform.Rotate(0, (float)-.5, 0);
        }

        if ((transform != null) && Input.GetKey("up"))
        {
            transform
        }
    }
}
