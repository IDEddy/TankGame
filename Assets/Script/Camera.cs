﻿using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {


    public Transform player;
    public float distance;
	// Use this for initialization
	void Start () {
       
    }
	
	// Update is called once per frame

	void Update () {

        Vector3 pos = transform.position;


        pos.z = player.position.z;
        pos.x = player.position.x;
        pos.y = player.position.y;

        
    }
}
