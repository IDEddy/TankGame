using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour
{

    public GameObject enemy;
    public GameObject ammo;
    public GameObject speedPill;

    public int minSpawn;
    public int maxSpawn;


    void Start()
    {
        StartCoroutine(SpawnStuff());


    }

    IEnumerator SpawnStuff()
    {


        while (true)
        {
            int rarity = Random.Range(0, 100);
            int rarity2 = Random.Range(0, 100);

            int range1 = Random.Range(minSpawn, maxSpawn);
            int range2 = Random.Range(minSpawn, maxSpawn);


            int range3 = Random.Range(minSpawn, maxSpawn);
            int range4 = Random.Range(minSpawn, maxSpawn);

            int range5 = Random.Range(minSpawn, maxSpawn);
            int range6 = Random.Range(minSpawn, maxSpawn);



            Instantiate(enemy, new Vector3(range1, 1, range2), Quaternion.identity);

            yield return new WaitForSeconds(1f);




            /**how rare you want the objects to be spawned **/

            if (rarity <= 50)
            {

                Instantiate(ammo, new Vector3(range3, 1, range4), Quaternion.identity);


                yield return new WaitForSeconds(1f);
            }

            if (rarity2 <= 30)
            {
                Instantiate(speedPill, new Vector3(range5, 1, range6), Quaternion.identity);

            }

        }






    }
}