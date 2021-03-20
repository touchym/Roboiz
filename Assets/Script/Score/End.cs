using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class End : MonoBehaviour
{
    // Start is called before the first frame update

    int scorePic;
    int scoreOil;
    int z;
    public Text tscorePic;
    public Text tscoreOil;
    public Text ttime;


    void Start()
    {
        tscorePic.text = "scorePic : " + ScorePic.scoreValue.ToString();
        tscoreOil.text = "scoreOil : " + ScoreOil.scoreValue.ToString();


        z = PlayerPrefs.GetInt("time", 0);
        ttime.text = "time : " + TimeCount.n.ToString()+" s";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
