using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreOil : MonoBehaviour
{
    // Start is called before the first frame update

    public static int scoreValue;
    private Text t;

    private GUIStyle guiS = new GUIStyle();

    void Start()
    {
        t = GetComponent<Text>();
        //scoreValue = 0;

    }

    // Update is called once per frame
    void Update()
    {
        t.text = "Score Oil : " + scoreValue.ToString();

    }
}
