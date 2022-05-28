using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GamePlayManager : MonoBehaviour
{

    int totalBrake;

    public Text totalBrakeText;
    public GameObject ballSpawnerObj;
    BallSpawner ballSpawner;

    void Start()
    {
        ballSpawner = ballSpawnerObj.GetComponent<BallSpawner>();
        ballSpawner.Spawn(1, ballSpawnerObj.transform.position);
    }


    void Update()
    {
        totalBrakeText.text = "Total " + totalBrake.ToString();

    }

    public void incrementBrake(Vector3 ballPostion)
    {
        totalBrake++;

        if (totalBrake > 3)
        {
            ballSpawner.Spawn(3, ballPostion);
        }
    }
}
