using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    private float hsp;
    private float vsp;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hsp = Input.GetAxisRaw("Horizontal");
        vsp = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate() {
        GetComponent<Rigidbody2D>().velocity = new Vector2(hsp * speed, vsp * speed);
    }
}
