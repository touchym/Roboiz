using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class McontrolblockYellow : MonoBehaviour
{
    // Start is called before the first frame update

    private float startPosX;
    private float startPosY;
    private bool isBeingHeld = false;
    public float n=0.5f;

    public GameObject stamina;

    Rigidbody2D rb;

     void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
            if (isBeingHeld == true)
        {
            n -= Time.deltaTime;
            Vector3 mousePos;

            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            this.gameObject.transform.localPosition = new Vector3(mousePos.x-startPosX, mousePos.y-startPosY, 0);

            stamina.transform.localScale -= new Vector3(0.033f, 0, 0);
            Debug.Log(n);

            //rb.AddForce(this.gameObject.transform.localPosition);
        }
        if (n <= 0)
        {
            
            isBeingHeld = false;
            stamina.transform.localScale = new Vector3(1, 1, 1);
            // n = 2;
        }
    }
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;

            isBeingHeld = true;
        }
    }
    private void OnMouseUp()
    {
        isBeingHeld = false;
        n = 0.5f;
        stamina.transform.localScale = new Vector3(1, 1, 1);
    }
}
