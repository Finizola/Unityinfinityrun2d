using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rig2D;
    private Animator animator2d;
    public static Player instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        rig2D = GetComponent<Rigidbody2D>();
        animator2d = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        rig2D.velocity = new Vector2(2f, rig2D.velocity.y);
        
        if(Input.GetMouseButtonDown(0))
        {
            rig2D.AddForce(Vector2.up * 3, ForceMode2D.Impulse);
        }
    }
}
