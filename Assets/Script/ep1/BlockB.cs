using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockB : MonoBehaviour
{
    public Transform blockB;


    public Vector3 closePositionB = new Vector3(0, 0, 0);
    public Vector3 openPositionB = new Vector3(0, 0, 0);

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
            blockB.position = Vector3.Lerp(blockB.position, openPositionB, Time.deltaTime * openSpeed);
        }
        else
        {
            blockB.position = Vector3.Lerp(blockB.position, closePositionB, Time.deltaTime * openSpeed);
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "yellowtag")
        {
            openA();
        }
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "yellowtag")
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
