using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorePic : MonoBehaviour
{
    public static int scoreValue;
    private Text t;

    private GUIStyle guiS = new GUIStyle();

    void Start()
    {
        t = GetComponent<Text>();
       // scoreValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        t.text = "Score Pic : " + scoreValue.ToString();
    }
}
