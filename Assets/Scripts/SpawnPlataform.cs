using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlataform : MonoBehaviour
{
    public List<GameObject> plataformsList = new List<GameObject>();
    Transform _transform;
    int contador = 1;
    bool proximo;
    float offSet = 15;
    float plataformX;
    float deadEnd;
    int respawContador = 1;




    void Start()
    {
        
      
        
    }

    // Update is called once per frame
    void Update()
    {
        
        var playerX = Player.instance.transform.position.x;
        if (playerX > respawContador * 17)
        {
            var p = Instantiate(plataformsList[Random.Range(0, 4)], new Vector2(contador * 25, 0), transform.rotation).transform;
            contador++;
            respawContador++;
            Destroy(p.gameObject, 10f);
        }
       
       
            //plataformX = p.GetComponent<Collider2D>().bounds.max.x;
            
            deadEnd = playerX - offSet;
            Debug.Log($"plataforma: {plataformX}\n player: {playerX}");
            //Destroy(p, 1f);
            //if (plataformX > deadEnd)
            //{
            //    Debug.Log("BOOM!");

            //    proximo = true;
            //    Debug.Log(proximo);
            //}
        

    }
}


        




