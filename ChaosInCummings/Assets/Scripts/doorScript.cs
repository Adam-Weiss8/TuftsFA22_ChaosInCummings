using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorScript : MonoBehaviour
{


    public GameObject player;
    private int keyCount;
    public int unlockAmount = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        keyCount = player.GetComponent<PlayerMove>().getKeyCount();

        if (keyCount >= unlockAmount)
        {
            Destroy(gameObject);
        }


    }
}
