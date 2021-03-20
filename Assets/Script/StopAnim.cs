using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAnim : MonoBehaviour
{
    void stopAni()
    {
        this.GetComponent<Animator>().SetBool("isboom", false);
        
        Destroy(gameObject);
    }
}
