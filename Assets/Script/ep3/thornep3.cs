using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thornep3 : MonoBehaviour
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
            ScoreOil.scoreValue = PlayerPrefs.GetInt("scoreOilEp2", ScoreOil.scoreValue);
            ScorePic.scoreValue = PlayerPrefs.GetInt("scorePicEp2", ScorePic.scoreValue);
        }
    }
}
