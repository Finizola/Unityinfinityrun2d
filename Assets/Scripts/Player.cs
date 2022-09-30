using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rig2D;
    private Animator animator2d;
    public static Player instance;
    private GameObject smoke;

    private bool isGround;
    int puloDuplo;
    private GameObject destroyTerrain;
    private GameObject destroyBullet;

    private Animacao animacao;
    public Transform gunPoint;
    public GameObject Bullet;
    private Transform gunDirection;
    private Transform posicaoXY;
       
   

    private void OnCollisionEnter2D(Collision2D collision)
    {
       if(collision.gameObject.layer == 3)
        {
            isGround = true;
            //puloDuplo = 2;
        }
    
        if (collision.gameObject.CompareTag("TerrainA"))
        {
            destroyTerrain = GameObject.FindGameObjectWithTag("TerrainA");
            Destroy(destroyTerrain, 5f);
            //Debug.Log("boom!");
        }

    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            isGround = true;
            //puloDuplo = 2;
        }

        if (collision.gameObject.CompareTag("TerrainA"))
        {
            destroyTerrain = GameObject.FindGameObjectWithTag("TerrainA");
            Destroy(destroyTerrain, 6f);
            //Debug.Log("boom!");
        }
    }



    void Start()
    {
        transform.GetChild(0).gameObject.SetActive(false);
        instance = this;
        rig2D = GetComponent<Rigidbody2D>();
        animator2d = GetComponent<Animator>();
        puloDuplo = 2;
        animacao = GetComponent<Animacao>();
        posicaoXY = GetComponent<Transform>();
        

    }

    // Update is called once per frame


    private void FixedUpdate()
    {
        rig2D.velocity = new Vector2(5f , rig2D.velocity.y);
    }

    void Update()
    {
        Debug.Log(isGround);
        if (isGround == true)
        {
            transform.GetChild(0).gameObject.SetActive(false);
        }
        if (isGround == false)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
           

        if (Input.GetMouseButtonDown(0) && isGround == true)
        {
            isGround = false;
            rig2D.AddForce(Vector2.up * 6, ForceMode2D.Impulse);
            animacao.ChangeAnimationState(Animacao.PLAYER_JUMP);
            //transform.GetChild(0).gameObject.SetActive(true);

            puloDuplo--;
            if (puloDuplo == 0 )
                {
                    isGround = false;
                    Debug.Log("zerou");
                    puloDuplo = 2;
                    animacao.ChangeAnimationState(Animacao.PLAYER_WALK);
                    //transform.GetChild(0).gameObject.SetActive(true);
            }
            
           

        }
        
        if(Input.GetMouseButtonDown(1))
        {

            GameObject bala = Instantiate(Bullet);
            bala.transform.position = gunPoint.transform.position;
            bala.GetComponent<Rigidbody2D>().velocity = new Vector2(10f, 0);
            Destroy(bala, 1f);

        }
        if (transform.position.y < -5f)
        {
            //Debug.Log("morreu!");
            animacao.ChangeAnimationState(Animacao.PLAYER_DIE);
            transform.GetChild(0).gameObject.SetActive(false);
        }
    }
}
