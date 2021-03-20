using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitScorePlus : MonoBehaviour
{
    // Start is called before the first frame update

   // public GameObject player;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("scoreOil", ScoreOil.scoreValue);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
            if (col.gameObject.tag=="Player")
            {
              Destroy(gameObject);
                ScoreOil.scoreValue++;
            }

    }
}
