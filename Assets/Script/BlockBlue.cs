using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBlue : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ibulletTag;
    public GameObject enBullet;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "iBulletTag")
        {
            Destroy(gameObject);
            
        }
        if (coll.gameObject.tag == "bb")
        {
            Destroy(gameObject);
        }
    }
    
}
