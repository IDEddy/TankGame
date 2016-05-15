using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    // Use this for initialization
    public float enemySpeed;
    Transform targetAmmo;

	void Start () {


       // targetAmmo = GameObject.FindGameObjectsWithTag("Spawn_prefab(Clone)").transform;



	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.right * enemySpeed * Time.deltaTime);
        transform.Translate(Vector3.up * enemySpeed * Time.deltaTime);

    }
}
