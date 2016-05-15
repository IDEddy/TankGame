using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {


    public Transform player;
    public float distance;
	// Use this for initialization
	void Start () {
       
    }
	
	// Update is called once per frame

	void Update () {

        transform.position = player.position + distance;

        
    }
}
