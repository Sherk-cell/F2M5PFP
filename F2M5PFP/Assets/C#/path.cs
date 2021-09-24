using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class path : MonoBehaviour
{

    [SerializeField] private Waypoints[] waypoints;

    public Waypoints getpathstart()
    {
        return waypoints[0];
    }
    public Waypoints getpathend()
    {
        return waypoints[waypoints.Length - 1];
    }

    public Waypoints GetNextWaypoint (Waypoints currentwaypoint)
    {
        for (int i = 0; i < waypoints.Length; i++)
        {
            if (waypoints[i] == currentwaypoint)
            {
                return waypoints[i + 1];
            }


           



          
        }
        return null;


    }










    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
