using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootSomething : MonoBehaviour
{
    public ScoringSystem Scoring;
    public GameObject projectile;
    public Vector2 velocity;
    bool canShoot = true;
    public Vector2 offset = new Vector2(0.4f, 0.1f);
    public float cooldown = 1f;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.T) && canShoot)
        {

            GameObject go = (GameObject)Instantiate(projectile, (Vector2)transform.position + offset * transform.localScale.x, Quaternion.identity);

            go.GetComponent<Rigidbody2D>().velocity = new Vector2(velocity.y * transform.localScale.x, velocity.x);


            //StartCoroutine(CanShoot());

            //GetComponent<Animator>().SetTrigger("shoot");

        }


    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            Scoring._score();
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }


    //IEnumerator CanShoot()
    //{
    //    canShoot = false;
    //    yield return new WaitForSeconds(cooldown);
    //    canShoot = true;


    //}
}