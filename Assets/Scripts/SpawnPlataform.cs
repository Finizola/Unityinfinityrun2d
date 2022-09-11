using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlataform : MonoBehaviour
{
    public List<GameObject> plataformsList = new List<GameObject>();
    Transform _transform;
    int contador = 1;
    bool proximo;
    float plataformX;
    float deadEnd;
    int respawContador = 1;



    // Update is called once per frame
    void Update()
    {
        
        var playerX = Player.instance.transform.position.x;
        if (playerX >= respawContador * 17)
        {
            //Debug.Log(playerX);
            var p = Instantiate(plataformsList[Random.Range(0, 4)], new Vector2(contador * 25, 0), transform.rotation).transform;
            var offSet = -playerX + p.GetComponent<BoxCollider2D>().bounds.max.x;
            contador++;
            respawContador++;
           
            //Debug.Log($"P: {p.transform.position.x}");
            
        }
       
    }
}


        




