using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    public Animator anim;
    public float speed;
    private float hsp;
    private float vsp;
    private bool isRun;
    public float runMultiplyer = 1.5f;

    //key ui
    public Text numberOfKeys;
    public int keyCount = 0; //changed to public (Minnie)


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //animate player
        if (hsp == 0 && vsp == 0)
        {
            anim.SetTrigger("idle");
        } else if(hsp > 0) {
            this.transform.localScale = new Vector3(1, 1, 1);
            anim.SetTrigger("walk");
        } else if (hsp < 1) {
            this.transform.localScale = new Vector3(-1, 1, 1);
            anim.SetTrigger("walk");
        }
        
        hsp = Input.GetAxisRaw("Horizontal");
        vsp = Input.GetAxisRaw("Vertical");
        isRun = Input.GetKey(KeyCode.LeftShift);


    
    }

    private void FixedUpdate() {
        if (isRun)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(hsp * speed * runMultiplyer, vsp * speed * runMultiplyer);
        } else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(hsp * speed, vsp * speed);
        }
    }

    public void addKey()
    {
        keyCount++;
        numberOfKeys.text = keyCount.ToString();
    }
}
