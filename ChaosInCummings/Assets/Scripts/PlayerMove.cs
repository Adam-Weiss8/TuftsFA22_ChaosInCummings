using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    private float hsp;
    private float vsp;
    public GameObject cursor;
    public GameObject bullet;

    public Transform firepoint;
    public float bulletSpeed = 10f;

    Vector2 lookDirection;
    float lookAngle;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hsp = Input.GetAxisRaw("Horizontal");
        vsp = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
           GameObject bulletClone = Instantiate(bullet, firepoint.position, firepoint.rotation);
           bulletClone.GetComponent<Rigidbody2D>().AddForce(firepoint.right * bulletSpeed, ForceMode2D.Impulse);
        }
    }

    private void FixedUpdate() {

        lookDirection = cursor.transform.position;
        lookDirection = lookDirection - GetComponent<Rigidbody2D>().position;

        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;

        GetComponent<Rigidbody2D>().rotation = lookAngle;

        GetComponent<Rigidbody2D>().velocity = new Vector2(hsp * speed, vsp * speed);
    }
}
