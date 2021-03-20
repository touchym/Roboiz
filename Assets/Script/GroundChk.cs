using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChk : MonoBehaviour
{
    // Start is called before the first frame update

     Charcon charcon;


    void Start()
    {
        charcon = gameObject.GetComponentInParent<Charcon>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        charcon.grounded = true;
    }
   void OnTriggerStay2D(Collider2D col)
    {
        charcon.grounded = true;
    }
   void OnTriggerExit2D(Collider2D col)
    {
        charcon.grounded=false;
    }
}
