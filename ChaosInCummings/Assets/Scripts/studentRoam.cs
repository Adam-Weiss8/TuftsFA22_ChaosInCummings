using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class studentRoam : MonoBehaviour
{

    public float enemySpeed;


    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range((float)0.5, 1) * enemySpeed, Random.Range((float)0.5, 1) * enemySpeed);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<Rigidbody2D>().velocity.x > 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = false;
        } else {
            this.GetComponent<SpriteRenderer>().flipX = true;
        }
    }

    /*
    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range((float)0.5, 1) * enemySpeed, Random.Range((float)0.5, 1) * enemySpeed);
    }
    */
}
