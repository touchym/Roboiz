using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportEp2 : MonoBehaviour
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
            Application.LoadLevel("ep3");
            PlayerPrefs.SetInt("scoreOilEp2", ScoreOil.scoreValue);
            PlayerPrefs.SetInt("scorePicEp2", ScorePic.scoreValue);
        }
    }
}
