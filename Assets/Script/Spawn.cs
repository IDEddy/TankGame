using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour
{

    public GameObject clone;
    public int minSpawn;
    public int maxSpawn;


    void Start()
    {
        StartCoroutine(SpawnAmmo());


    }

    IEnumerator SpawnAmmo()
    {



        while (true)
        {

            int range1 = Random.Range(minSpawn, maxSpawn);
            int range2 = Random.Range(minSpawn, maxSpawn);

            Instantiate(clone, new Vector3(range1, 1, range2), Quaternion.identity);

            yield return new WaitForSeconds(1f);


        }
    }
}