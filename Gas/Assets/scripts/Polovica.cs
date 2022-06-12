using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Polovica : MonoBehaviour
{
   public GameObject Zavrseni;
   public GameObject Pola;

   void onTriggerEnter ()
   {
       Zavrseni.SetActive (true);
       Pola.SetActive (false);
   }
}
