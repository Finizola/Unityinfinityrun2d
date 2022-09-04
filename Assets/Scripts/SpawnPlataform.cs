using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlataform : MonoBehaviour
{
    public List<GameObject> plataformsList = new List<GameObject>();
    Transform _transform;
    int contador = 0;
    bool proximo;
    Transform p;
    Collider2D colisao;

    void Start()
    {
        //for (int i = 0; i < plataformsList.Count; i++)
        //{
        //    p = Instantiate(plataformsList[Random.Range(0, 4)], new Vector2(i * 25, 0), transform.rotation).transform;
        //    Debug.Log(proximo);

        //}
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(proximo);
        p = Instantiate(plataformsList[Random.Range(0, 4)], new Vector2(contador * 25, 0), transform.rotation).transform;
        contador++;
        Debug.Log(p);
        //colisor2dBox = p.GetComponent<Collider2D>().b;
        //Debug.Log(contador);

        var playerX = Player.instance.transform.position.x;
        var offSet = 15;
        var deadEnd = playerX - offSet;
        //var plataformX = transform.GetComponentInChildren<Collider2D>().bounds.max.x;

        //if (plataformX < deadEnd)
        //{
        //    //Debug.Log($"plataforma: {plataformX}\n player: {playerX}");
        //    GameObject.Destroy(transform.gameObject);
        //    proximo = true;
        //    Debug.Log(proximo);
        //}


    }
}


        




