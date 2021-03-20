using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCount : MonoBehaviour
{
    // Start is called before the first frame update

    public Text t;
    public static float n;
    int a;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        n += Time.deltaTime;
        // t.text = n.ToString();
        t.text = "Time : " + System.Math.Round(n, 1).ToString()+" s";
       // n = a;

        PlayerPrefs.SetFloat("time", n);
    }
}
