using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Interface : MonoBehaviour
{

    // Use this for initialization
    public static int score;
    public static float seconds = 0f;
    public static int ammo;

    public GameObject timerObject;
    public GameObject scoreObject;
    public GameObject ammoObject;

    int roundedSeconds;
    int minutes;

    Text textScore;
    Text timer;
    Text textAmmo;
    

    void Awake()
    {

        textScore = scoreObject.GetComponent<Text>();
        textAmmo = ammoObject.GetComponent<Text>();
        timer = timerObject.GetComponent<Text>();

        score = 0;
        ammo = 0;

    }

    void Update()
    {
        /** records the time,score, and ammo count **/
        seconds += Time.deltaTime;

        roundedSeconds = Mathf.RoundToInt(seconds);

        minutes = roundedSeconds / 60;


        textScore.text = "SCORE: " + score;

        timer.text = "Time:   " + minutes + " : " + roundedSeconds;

        textAmmo.text = "Ammo: " + ammo;


    }


}
