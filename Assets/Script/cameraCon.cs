using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraCon : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public float dempTime = 0.4f;
    private Vector3 cameraPos;
    private Vector3 velocity = Vector3.zero;

    void Start()
    {
        cameraPos = new Vector3(player.position.x, player.position.y, -10f);
        transform.position = Vector3.SmoothDamp(gameObject.transform.position, cameraPos, ref velocity, dempTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
