﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraFollow : MonoBehaviour

{
    public GameObject follow;
    public Vector2 minCampos, maxCampos; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float posX= follow.transform.position.x;
        float posY = follow.transform.position.y;

        transform.position = new Vector3(posX, posY, transform.position.z);
        

    }
}
