using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorExit_Items : MonoBehaviour{
      // NOTE: This script depends on the GameHandler having a public int "thePieces"
      // that is updated with each pickup collected.
      //public GameHandler gameHandler;
      public string NextLevel = "Starbucks_Scene";
      
      public GameObject exitClosed;
      public GameObject exitOpen;
      
      public GameObject player;

      public int piecesCollected;
      public int piecesNeeded = 4;

      void Start(){
            player.GetComponent<PlayerMove>();
            exitClosed.SetActive(true);
            exitOpen.SetActive(false);
            gameObject.GetComponent<Collider2D>().enabled = false;
      }

      void Update(){
            piecesCollected = player.GetComponent<PlayerMove>().keyCount;
            if (piecesCollected >= piecesNeeded){
                  exitClosed.SetActive(false);
                  exitOpen.SetActive(true);
                  gameObject.GetComponent<Collider2D>().enabled = true;
            }
            else {
                  gameObject.GetComponent<Collider2D>().enabled = false;
            }
      }

      public void OnTriggerEnter2D(Collider2D other){
            if (other.gameObject.tag == "Player"){
                  SceneManager.LoadScene (NextLevel);
                Destroy(gameObject);
            }
      }
}
