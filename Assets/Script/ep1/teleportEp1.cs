using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportEp1 : MonoBehaviour
{
    // Start is called before the first frame update
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
            Application.LoadLevel("ep2");
            PlayerPrefs.SetInt("scoreOilEp1", ScoreOil.scoreValue);
            PlayerPrefs.SetInt("scorePicEp1", ScorePic.scoreValue);

        }
    }
}
