using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DreamCar01_Track : MonoBehaviour
{
    public GameObject TheMarker;
    public GameObject Mark01;
    public GameObject Mark02;
    public GameObject Mark03;
    public GameObject Mark04;
    public GameObject Mark05;
    public GameObject Mark06;
    public GameObject Mark07;
    public GameObject Mark08;
    public GameObject Mark09;
    public GameObject Mark011;
    public GameObject Mark012;
    public GameObject Mark013;
    public GameObject Mark014;
    public GameObject Mark015;
    public GameObject Mark016;
    public GameObject Mark017;
    public GameObject Mark018;
    public GameObject Mark019;
    public GameObject Mark020;
    public GameObject Mark021;
    public GameObject Mark022;
    public GameObject Mark023;
    public GameObject Mark024;
    public int MarkTracker;

    void Update()
    {
        if (MarkTracker == 0)
        {
            TheMarker.transform.position = Mark01.transform.position;
        }
        if (MarkTracker == 1)
        {
            TheMarker.transform.position = Mark02.transform.position;
        }
        if (MarkTracker == 2)
        {
            TheMarker.transform.position = Mark03.transform.position;
        }
        if (MarkTracker == 3)
        {
            TheMarker.transform.position = Mark04.transform.position;
        }
        if (MarkTracker == 4)
        {
            TheMarker.transform.position = Mark05.transform.position;
        }
        if (MarkTracker == 5)
        {
            TheMarker.transform.position = Mark06.transform.position;
        }
        if (MarkTracker == 6)
        {
            TheMarker.transform.position = Mark07.transform.position;
        }
        if (MarkTracker == 7)
        {
            TheMarker.transform.position = Mark08.transform.position;
        }
        if (MarkTracker == 8)
        {
            TheMarker.transform.position = Mark09.transform.position;
        }
        if (MarkTracker == 9)
        {
            TheMarker.transform.position = Mark011.transform.position;
        }
        if (MarkTracker == 10)
        {
            TheMarker.transform.position = Mark012.transform.position;
        }
        if (MarkTracker == 11)
        {
            TheMarker.transform.position = Mark013.transform.position;
        }
        if (MarkTracker == 12)
        {
            TheMarker.transform.position = Mark014.transform.position;
        }
        if (MarkTracker == 13)
        {
            TheMarker.transform.position = Mark015.transform.position;
        }
        if (MarkTracker == 14)
        {
            TheMarker.transform.position = Mark016.transform.position;
        }
        if (MarkTracker == 15)
        {
            TheMarker.transform.position = Mark017.transform.position;
        }
        if (MarkTracker == 16)
        {
            TheMarker.transform.position = Mark018.transform.position;
        }
        if (MarkTracker == 17)
        {
            TheMarker.transform.position = Mark019.transform.position;
        }
        if (MarkTracker == 18)
        {
            TheMarker.transform.position = Mark020.transform.position;
        }
        if (MarkTracker == 19)
        {
            TheMarker.transform.position = Mark021.transform.position;
        }
        if (MarkTracker == 20)
        {
            TheMarker.transform.position = Mark022.transform.position;
        }
        if (MarkTracker == 21)
        {
            TheMarker.transform.position = Mark023.transform.position;
        }
        if (MarkTracker == 22)
        {
            TheMarker.transform.position = Mark024.transform.position;
        }
    }
     IEnumerator OnTriggerEnter(Collider collision) {
        if(collision.gameObject.tag == "DreamCar01") {
            this.GetComponent<BoxCollider>().enabled = false;
            MarkTracker += 1;
            if(MarkTracker == 22) {
                MarkTracker = 0;
            }
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }
}
