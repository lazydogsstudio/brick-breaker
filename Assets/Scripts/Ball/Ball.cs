using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Ball : MonoBehaviour
{

    public float speed = 5f;

    GameObject tilemapGameObject;

    GamePlayManager gamePlayManager;

    Tilemap tilemap;

    void Start()
    {
        tilemapGameObject = GameObject.Find("Obj");

        Respawn();
        if (tilemapGameObject != null)
        {
            tilemap = tilemapGameObject.GetComponent<Tilemap>();
        }
    }

    private void Update()
    {
        if (transform.position.y < -10f)
        {
            Destroy(gameObject);
        }


    }


    void Respawn()
    {
        GetComponent<Rigidbody2D>().velocity = Random.insideUnitCircle.normalized * speed;
        gamePlayManager = GameObject.Find("Game Play Manager").GetComponent<GamePlayManager>();
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        Vector3 hitPosition = Vector3.zero;
        if (tilemap != null && tilemapGameObject == collision.gameObject)
        {

            foreach (ContactPoint2D hit in collision.contacts)
            {
                hitPosition.x = hit.point.x - 0.01f * hit.normal.x;
                hitPosition.y = hit.point.y - 0.01f * hit.normal.y;
                tilemap.SetTile(tilemap.WorldToCell(hitPosition), null);


                gamePlayManager.incrementBrake(transform.position);
            }


        }
    }

}
