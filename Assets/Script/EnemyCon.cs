using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCon : MonoBehaviour
{
    // Start is called before the first frame update

    Animator an;
    public GameObject charactor, enemy;
    float scaleX, scaleY;
    bool isLeft;

    public GameObject bulletPoint;
    public GameObject bulletPrefab;

        public float distanceOBJ;
        public float distanceWalk=15;
        public float distanceBull=10;

    float n = 1f;
    public float speed = 0.08f;

    void Start()
    {
        an = enemy.GetComponent<Animator>();

        scaleX = transform.localScale.x;
        scaleY = transform.localScale.y;
    }

    // Update is called once per frame
    void Update()
    {
        setAIenemy();
    }
    void setAIenemy()
    {
        distanceOBJ = Vector2.Distance(charactor.transform.position, transform.position);
       // Debug.Log(distanceOBJ);
        //print(distanceOBJ);
        if (distanceOBJ > distanceWalk)
        {
            an.SetBool("isWalk", false);

        }
        else if (distanceOBJ > distanceBull)
        {
            an.SetBool("isWalk", true);
            if (isLeft) transform.position += new Vector3(-speed, 0, 0);
            else transform.position += new Vector3(speed, 0, 0);

            if (n >= 1f)
            {
                addBullet();
                n = 0;
            }
            n += Time.deltaTime;


        }
        else
        {
            an.SetBool("isWalk", false);
              if (n >= 1f)
            {
                
                addBullet();
                n = 0;
            }
            n += Time.deltaTime;
        }


        if (transform.position.x > charactor.transform.position.x)
        {
            transform.localScale = new Vector3(-scaleX, scaleY, 1);
            isLeft = true;
        }
        else
        {
            transform.localScale = new Vector3(scaleX, scaleY, 1);
            isLeft = false;
        }
    }
    void addBullet()
    {
        float posX = bulletPoint.transform.position.x;
        float posY = bulletPoint.transform.position.y;
        Vector3 prefabPos = new Vector3(posX, posY, 0);
        Instantiate(bulletPrefab, prefabPos, Quaternion.identity);
    }
}
