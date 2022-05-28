using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{

    public GameObject ballPrefab;

    public void Spawn(int ballCount, Vector3 ballPostion)
    {
        // for (int i = 0; i < ballCount; i++)
        // {
        Instantiate(ballPrefab, ballPostion, Quaternion.identity);
        //}
    }
}
