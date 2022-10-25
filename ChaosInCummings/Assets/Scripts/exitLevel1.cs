using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exitLevel1 : MonoBehaviour{
      // NOTE: This script depends on the GameHandler having a public int "thePieces"
      // that is updated with each pickup collected.
      //public GameHandler gameHandler;
      public string NextLevel = "Starbucks_Scene";
      
  
     
      public void OnTriggerEnter2D(Collider2D other){
            if (other.gameObject.tag == "Player"){
                  SceneManager.LoadScene (NextLevel);
                  gameObject.SetActive(false);
            }
      }
}
