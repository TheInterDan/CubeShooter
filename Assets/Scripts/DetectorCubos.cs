using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorCubos : MonoBehaviour {

    public int score;

   void OnTriggerEnter(Collider other)
   {
        Debug.Log("detected");
      if (other.gameObject.tag == "detector")
      {
            Destroy(other.gameObject);
            GameManager.CubeDestroyed();
      }
   }
}
