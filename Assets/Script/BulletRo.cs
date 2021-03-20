using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletRo : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    Animator an;
    public float speed = 15;


    //public GameObject box1;

    void Start()
    {
        rotateFollowMouse();
        rb = GetComponent<Rigidbody2D>();
        an=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.right * speed);
        float posX = transform.position.x;
        float posY = transform.position.y;
        if ((posX <= -300) || (posX >= 300) || (posY <= -300) || (posY >= 300))
        {
            Destroy(gameObject);
        }
    }
    void rotateFollowMouse()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 5.23f;
        //Debug.Log(mousePos);
        Vector3 objectPos = Camera.main.WorldToScreenPoint(transform.position);
        mousePos.x = mousePos.x - objectPos.x;
        mousePos.y = mousePos.y - objectPos.y;

        float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Destroy(gameObject);
        //Destroy(box1.gameObject);
        an.SetBool("isboom", true);
    }
}
