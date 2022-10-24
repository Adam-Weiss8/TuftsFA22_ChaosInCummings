using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class keyPickup : MonoBehaviour
{
    private bool playerInRange = false;
    public Text pickupPrompt;
    public GameObject player;
    

    private void Start()
    {
        pickupPrompt.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            pickupKey();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")){
            pickupPrompt.gameObject.SetActive(true);
            playerInRange = true;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            pickupPrompt.gameObject.SetActive(false);
            playerInRange = false;
        }
    }

    void pickupKey()
    {
        player.GetComponent<PlayerMove>().addKey();
        Destroy(gameObject);
    }
}
