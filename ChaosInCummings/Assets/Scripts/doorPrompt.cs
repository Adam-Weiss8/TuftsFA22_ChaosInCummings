using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class doorPrompt : MonoBehaviour
{

    public GameObject player;
    public Text doorPromptText;
    // Start is called before the first frame update
    void Start()
    {
        doorPromptText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<PlayerMove>().getKeyCount() >= 10)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            doorPromptText.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            doorPromptText.gameObject.SetActive(false);
        }
    }
}
