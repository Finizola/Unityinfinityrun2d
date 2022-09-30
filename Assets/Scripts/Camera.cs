using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
   
    Transform positionX;
    // Start is called before the first frame update
    void Start()
    {
        
        positionX = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        var playerX = Player.instance.transform.position.x;
        var playerY = Player.instance.transform.position.y;

        //if (playerY 10f)
        //{
        //    Debug.Log("opa caiu");
        //    transform.position = new Vector2(playerX, playerY);
        //}

        //transform.position = new Vector2(transform.position.x + 5f * Time.deltaTime,transform.position.y);

        transform.position = new Vector2(playerX, playerY);
    }
}
