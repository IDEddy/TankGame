using UnityEngine;
using System.Collections;

public class Control : MonoBehaviour
{

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

    /**    IEnumerator waitTime()
        {
            speed += 10;

            yield return new WaitForSeconds(4f);

            }

       **/
    void OnCollisionEnter(Collision col)
    {

        /**Collision detection for multiple objects in game **/

        if (col.gameObject.name == "Spawn_prefab(Clone)")
        {


            Destroy(col.gameObject);
            Interface.score += 100;

        }

        if (col.gameObject.name == "Ammo_prefab(Clone)")
        {
            Destroy(col.gameObject);

            Interface.ammo += 1;

        }

        if (col.gameObject.name == "speedPill_prefab(Clone)")
        {
            Destroy(col.gameObject);
            speed += 5;

        }



    }

    // Update is called once per frame
    void Update()
    {
        /** New way of moving player. Finds the angle first**/


        Quaternion rot = transform.rotation;
        float angle = rot.eulerAngles.x;

        /** note camera is top down. Some inputs need to be inverted.**/
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, xMin, xMax), 1, Mathf.Clamp(transform.position.z, yMin, yMax));


        // transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime);
        // transform.Translate(Vector3.up * Input.GetAxis("Vertical") * speed * Time.deltaTime);





        /**The direction the tank wants to go using WASD inputs**/

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);

        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed);

        }
        if (Input.GetKey(KeyCode.A))
        {

            transform.Translate(Vector3.left * Time.deltaTime * speed);

        }
        if (Input.GetKey(KeyCode.D))
        {

            transform.Translate(Vector3.right * Time.deltaTime * speed);

        }




        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 0, 90 * Time.deltaTime * speed);
        }

       /** if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Rotate(0, 0, -90 * Time.deltaTime * speed);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Rotate(0, 0, 90 * Time.deltaTime * speed);
        }
    **/
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0, -90 * Time.deltaTime * speed);
        }


    }
}