using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thornEp1 : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Application.LoadLevel("ep1");

            ScoreOil.scoreValue = 0;
            ScorePic.scoreValue = 0;

        }
    }
}
