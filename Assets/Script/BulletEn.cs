using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEn : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed;
    private Transform target;
    Animator an;
    public GameObject charz;
    float n;


    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        an = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, target.position)>0)
        {
            transform.position = Vector2.MoveTowards(transform.position,target.position, speed * Time.deltaTime);
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Destroy(gameObject);
        //Destroy(box1.gameObject);
        an.SetBool("isboom", true);

        if (collision.gameObject.tag == "Player")
        {
            Application.LoadLevel("ep2");
            ScoreOil.scoreValue = PlayerPrefs.GetInt("scoreOilEp1", ScoreOil.scoreValue);
            ScorePic.scoreValue = PlayerPrefs.GetInt("scorePicEp1", ScorePic.scoreValue);
        }
    }
}
