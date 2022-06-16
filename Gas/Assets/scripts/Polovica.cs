using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Polovica : MonoBehaviour
{
   public GameObject OvajCheckpoint;
   public GameObject IduciCheckpoint;

   void OnTriggerEnter()
   {
        OvajCheckpoint.SetActive(false);
        IduciCheckpoint.SetActive(true);
   }
}
