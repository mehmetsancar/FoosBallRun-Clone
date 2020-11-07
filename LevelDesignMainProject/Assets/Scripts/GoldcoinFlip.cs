﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldcoinFlip : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,20 * Time.deltaTime*2);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "MovingBall")
        {
         
            Manager.numberOfCoins += 1;
            Debug.Log("coins:" + Manager.numberOfCoins);
            Destroy(gameObject);
        }
    }
}
