using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointFollower : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    private int currentWaypointIndex = 0;
    bool wait = false;

    [SerializeField] private float speed = 2f;
    private void Update()
    {
        
        {
            // If Distance between current waypoint and object is less than .1f
            if (Vector2.Distance(waypoints[currentWaypointIndex].transform.position, transform.position) < .1f)
            {
                currentWaypointIndex++;
                if (currentWaypointIndex >= waypoints.Length)
                {
                    currentWaypointIndex = 0;
                }
                wait = true;
                Invoke(nameof(DoNotWait), 1.0f);
            }
            if (!wait)
            {
                // Moves towards the waypoint
                transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, Time.deltaTime * speed);
            }

        }
    }
    private void DoNotWait()
    {
        wait = false;
    }
}
