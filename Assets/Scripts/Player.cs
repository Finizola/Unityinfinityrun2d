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

    private Animacao animacao;

       
    // Start is called before the first frame update

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
            Destroy(destroyTerrain, 4f);
            Debug.Log("boom!");
        }
    }

    void Start()
    {
        instance = this;
        rig2D = GetComponent<Rigidbody2D>();
        animator2d = GetComponent<Animator>();
        puloDuplo = 2;
        animacao = GetComponent<Animacao>();
        //smoke = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        

        rig2D.velocity = new Vector2(5f, rig2D.velocity.y);
        
        if (Input.GetMouseButtonDown(0) && isGround == true)
        {
           rig2D.AddForce(Vector2.up * 4, ForceMode2D.Impulse);
           animacao.ChangeAnimationState(Animacao.PLAYER_JUMP);
            transform.GetChild(1).gameObject.SetActive(true);
           Debug.Log(puloDuplo);
           puloDuplo--;
           if (puloDuplo == 0 )
                {
                    isGround = false;
                    Debug.Log("zerou");
                    puloDuplo = 3;
                    animacao.ChangeAnimationState(Animacao.PLAYER_WALK);
                    transform.GetChild(1).gameObject.SetActive(false);
            }
         }
        
    }
}
