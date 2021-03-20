using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowTo : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject player;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x < -17.6)
        {
            player.transform.position = new Vector3(-15, 0, 0);
        }
        if (player.transform.position.x > 15.3)
        {
            player.transform.position = new Vector3(-15, 0, 0);
        }
    }
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            player.transform.position = new Vector3(-15, 0, 0);
            
        }
    }
    }
