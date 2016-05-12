using UnityEngine;
using System.Collections;

public class Control : MonoBehaviour {

    // Use this for initialization
    public float speed;
    //Camera is top down. Bounds are only based on the perspective.
    public float xMin;
    public float xMax;
    public float yMin;
    public float yMax;

    void Start()
    {


    }

    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.name == "Spawn_prefab(Clone)")
        {


            Destroy(col.gameObject);

        }



    }

    // Update is called once per frame
    void Update()
    {


        /** note camera is top down. Some inputs need to be inverted.**/
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, xMin, xMax), 1, Mathf.Clamp(transform.position.z, yMin, yMax));

        transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime);
        transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * speed * Time.deltaTime);

    }
}