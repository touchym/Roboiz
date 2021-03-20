using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitScorePic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("scorePic", ScorePic.scoreValue);
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            ScorePic.scoreValue++;

        }
    }
}
