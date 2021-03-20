using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sawCon : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(speed,0,0);
        float posX = transform.position.x;
        if (posX >= -12)
        {
            transform.position += new Vector3(speed, 0, 0);
        }
    }
}
