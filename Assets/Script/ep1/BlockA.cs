using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockA : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform blockA;

    public Vector3 closePositionA = new Vector3(0, 0, 0);
    public Vector3 openPositionA = new Vector3(0, 0, 0);

    public float openSpeed = 5;
    private bool open = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (open)
        {
            blockA.position = Vector3.Lerp(blockA.position, openPositionA, Time.deltaTime * openSpeed);
        }
        else
        {
            blockA.position = Vector3.Lerp(blockA.position, closePositionA, Time.deltaTime * openSpeed);
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            openA();
        }
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            closeA();
        }
    }
    public void closeA()
    {
        open = false;
    }
    public void openA()
    {
        open = true;
    }
}
