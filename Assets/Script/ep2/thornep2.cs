using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thornep2 : MonoBehaviour
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
            Application.LoadLevel("ep2");

            ScoreOil.scoreValue = PlayerPrefs.GetInt("scoreOilEp1", ScoreOil.scoreValue);
            ScorePic.scoreValue = PlayerPrefs.GetInt("scorePicEp1", ScorePic.scoreValue);
        }
    }
}
