using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CheckPoints : MonoBehaviour
{
    public bool missed = false;
    public GameObject PrevCheckPoint;
    public int lap = 0;
    public int checkPoint = -4;
    int checkPointCount;
    int nextCheckpoint = 0;
    Dictionary<int, bool> visited = new Dictionary<int, bool>();
    public Text lapText;


    void Start()

    {
        GameObject[] checkpoints = GameObject.FindGameObjectsWithTag("checkpoint");
        checkPointCount = checkpoints.Length;
        foreach(GameObject checpoint in checkpoints)
        { 
          if(checpoint.name == "0")
            {
                PrevCheckPoint = checpoint;
            }
        }
        foreach (GameObject cp in checkpoints)
        {
            visited.Add(Int32.Parse(cp.name), false);
        }
    }


    void OnTriggerEnter(Collider col)

    {

        if (col.gameObject.tag == "checkpoint")

        {

            int checkpointCurrent = int. Parse(col.gameObject.name);
            if (checkpointCurrent==nextCheckpoint)
        {
                PrevCheckPoint = col.gameObject;
                visited[checkpointCurrent] = true;
                checkPoint = checkpointCurrent;
                if (checkPoint == 0 && gameObject.tag == "Player")
                {
                    lap++;
                    lapText.text = "Lap:" + lap; 
                }
                        nextCheckpoint++;
                        if (nextCheckpoint >= checkPointCount)
                        {
                            var keys = new List<int>(visited.Keys);
                            foreach (int key in keys)
                            {
                                visited[key] = false;
                            }
                            nextCheckpoint = 0;
                        }
                    }
                }
            }
        }

            
        
