using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorCubos : MonoBehaviour {

    public int score;

   void OnTriggerEnter(Collider other)
   {
      if (other.gameObject.tag == "Cube")
      {
            GameManager.DestroyCube(other.gameObject);
      }
   }
}
