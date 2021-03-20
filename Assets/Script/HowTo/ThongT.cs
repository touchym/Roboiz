using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThongT : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public GameObject text;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            text.transform.position = new Vector3(500, 50, 0);
            Destroy(gameObject);
        }
    }
    }
