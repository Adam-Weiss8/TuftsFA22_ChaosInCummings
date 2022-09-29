using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public GameObject Bullet;
    public float bulletSpeed = 50f;

    Vector2 lookDirection;
    float lookAngle;
    
    void Update()
    {
        //calculate shot angle
        lookDirection = Camera.main.WorldToScreenPoint(Input.mousePosition);
        lookDirection = new Vector2(lookDirection.x - transform.position.x, lookDirection.y - transform.position.y);
        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, lookAngle);

        //spawn bullet
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bulletClone = Instantiate(Bullet);
            bulletClone.transform.position = transform.position;
            bulletClone.transform.rotation = Quaternion.Euler(0, 0, lookAngle);

            bulletClone.GetComponent<Rigidbody2D>().velocity = transform.right * bulletSpeed;

        }
    }
}
