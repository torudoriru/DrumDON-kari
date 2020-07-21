using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonScript : MonoBehaviour {
    float move = 0.05f;

    void Start()
    {
        Vector3 pos = transform.position;
        pos.x = 10.5f;
        pos.y = 1.2f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += move;
        if(pos.x < -4.0f)
        {
            move = 0.05f;
        }
        if(pos.x > 10.5f)
        {
            move = -0.05f;
        }
        transform.position = pos;
    }
}