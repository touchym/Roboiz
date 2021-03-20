using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject charactor;
    float horizontalmove = 0f;
    public float runspeed = 40f;
    Rigidbody2D rb;
    Animator an;
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        an=charactor.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        jump();
        anim();
    }
     void FixedUpdate()
    {
        Vector3 movement = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * runspeed;
    }
    void jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
        }
    }

    void anim()
    {
        if (Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.D))
        {
            an.SetBool("isWalk", true);
        }
        else
        {
            an.SetBool("isWalk", false);
        }
    }
}
