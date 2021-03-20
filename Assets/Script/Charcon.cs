using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charcon : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject charactor;
    Rigidbody2D rb;
    Animator an;
    public float runspeed = 5f;
    public bool grounded;
    public float jumpPow = 10;

    AudioSource audioB;
    public AudioClip jumpS;
    public AudioClip bullS;
    public AudioClip oilS;
    public AudioClip picS;

    float n = 0.5f;

    public GameObject bulletPoint;
    public GameObject bulletPrefab;

    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        an= charactor.GetComponent<Animator>();
        audioB = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        rotateFollowMouse();
        conChar();
        anim();
        if (Input.GetMouseButtonDown(1))
        {
           
            if (n >= 0.5f)
            {
                addBullet();
                n = 0;
                audioB.PlayOneShot(bullS);
            }
        }
        n += Time.deltaTime;
    }
    void conChar()
    {
        an.SetBool("grounded", grounded);
        Vector3 movement = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * runspeed;
        if (Input.GetButtonDown("Jump") && grounded)
        {
            rb.AddForce(Vector2.up * jumpPow);
            audioB.PlayOneShot(jumpS);
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



        float angle = Mathf.Atan2(mousePos.x, mousePos.y) * Mathf.Rad2Deg;
        if(angle > 0 && angle < 180)
        {
            transform.localScale = new Vector3(0.3806717f, 0.3806717f, 0.3806717f);
        }
        if (angle < 0 && angle > -180)
        {
            transform.localScale = new Vector3(-0.3806717f, 0.3806717f, 0.3806717f);
        }
       // Debug.Log(angle);

    }
    void anim()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            an.SetBool("isWalk", true);
        }
        else
        {
            an.SetBool("isWalk", false);
        }
    }
    void addBullet()
    {
        float posX = bulletPoint.transform.position.x;
        float posY = bulletPoint.transform.position.y;
        Vector3 prefabPos = new Vector3(posX, posY, 0);
        Instantiate(bulletPrefab, prefabPos, Quaternion.identity);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "oilTag")
        {
            audioB.PlayOneShot(oilS);
        }
        if (collision.gameObject.tag == "picTag")
        {
            audioB.PlayOneShot(picS);
        }
    }
}
