using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathfollower : MonoBehaviour
{

    [SerializeField] private float speed;
    [SerializeField] public float Treshold;
    public path path;
    public Waypoints currentwaypoint;

    private void Start()
    {
        SetupPath();
    }

    private void Update()
    {
        transform.LookAt(currentwaypoint.getposition());
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        float distancetoWaypoint = Vector3.Distance(transform.position, currentwaypoint.getposition());
        if (distancetoWaypoint <= Treshold)
        {
            print("ik ben in de buurt van een waypoint");
            if (currentwaypoint == path.getpathend())
            {
                pathComplete();
            }
            else
            {
                currentwaypoint = path.GetNextWaypoint(currentwaypoint);
                transform.LookAt(currentwaypoint.getposition());


            }

        }





    }

    private void SetupPath()
    {
        path = FindObjectOfType<path>();
        currentwaypoint = path.getpathstart();
        transform.LookAt(currentwaypoint.getposition());

    }
    private void pathComplete()
    {
        print("ik ben bij het eindpunt");
        speed = 0;

    }













}
