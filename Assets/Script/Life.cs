﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Untagged");
    }

    public void UseLife()
    {
        player.GetComponentInChildren<Width>().AddLife();
        Destroy(gameObject);
    }

    void Update()
    {
        
    }
}
