using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void playGame()
    {
        Application.LoadLevel("ep1");
        ScoreOil.scoreValue = 0;
        ScorePic.scoreValue = 0;
        TimeCount.n = 0;
    }
    public void howTo()
    {
        Application.LoadLevel("HowTo");
        ScoreOil.scoreValue = 0;
        ScorePic.scoreValue = 0;
        TimeCount.n = 0;
    }
    public void menu()
    {
        Application.LoadLevel("menu");
        ScoreOil.scoreValue = 0;
        ScorePic.scoreValue = 0;
        TimeCount.n = 0;
    }
    public void credit()
    {
        Application.LoadLevel("credit");
        ScoreOil.scoreValue = 0;
        ScorePic.scoreValue = 0;
        TimeCount.n = 0;
    }
}
