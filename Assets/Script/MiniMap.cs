using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMap : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;

    void LateUpdate()
    {
        Vector3 newposition = player.position;
        newposition.z = transform.position.z;
        transform.position = newposition;
    }
}
