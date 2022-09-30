using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunshot : MonoBehaviour
{

    public GameObject bullet;
    public void BulletTime()
    {
        Instantiate(bullet,new Vector2(transform.position.x ,transform.position.y),Quaternion.identity);
    }
    
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
