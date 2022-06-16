using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaptimeScripta : MonoBehaviour
{
    public static int Minute =1;
    public static int Sekunde =1;
    public static float MiliSekunde =1;
    public static string MiliPrikaz ;

    public GameObject MinuteBox;
    public GameObject SekundeBox;
    public GameObject MiliSekundeBox;

    void Update()
    {
        MiliSekunde += Time.deltaTime * 10;
        MiliPrikaz = MiliSekunde.ToString("F1"); 
        MiliSekundeBox.GetComponent<Text>  ().text = "" + MiliPrikaz;
        if(MiliSekunde >= 10)
        {
            MiliSekunde =0;
            Sekunde +=1;
        }
        if(Sekunde <=9)
        {
            SekundeBox.GetComponent<Text>  ().text = "0" + Sekunde + ".";
        }
        else
        {
            SekundeBox.GetComponent<Text>  ().text = "" + Sekunde + ".";
        }
        if (Sekunde >= 60)
        {
            Sekunde =0;
            Minute +=1;
        }
         if(Minute <=9)
        {
            MinuteBox.GetComponent<Text>  ().text = "0" + Minute + ":";
        }
        else
        {
            MinuteBox.GetComponent<Text>  ().text = "" + Minute + ":";
        }
    }
}
