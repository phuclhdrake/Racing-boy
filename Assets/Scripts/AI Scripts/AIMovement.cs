using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : MonoBehaviour
{
    List<GameObject> route;
    private Vector3 nextPoint;
    public GameObject AIPathHolder;
    private bool isAccPressed = false;
    AICars driver;
    int totalWayPoints;
    int currentIndex;
    private bool nextPos;
    private string turning;
    AIPathWay wayPoint;
    internal Transform currentWayPoint;


    void Start()
    {

        driver = GetComponent<AICars>();
        if (AIPathHolder != null)
        {
            driver.isAIMovement = true;
            wayPoint = AIPathHolder.GetComponent<AIPathWay>();
            route = wayPoint.route;
            currentIndex = 0;
            totalWayPoints = route.Count;
            currentWayPoint = route[0].transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if (!driver.isAIMovement) ;
        if (!nextPos)
        {
            nextPoint = currentWayPoint.position;
            nextPos = true;
        }
        Vector3 relativeVector = transform.InverseTransformPoint(nextPoint);
        turning = null;

        if (relativeVector.x > 0.5f)
        {
            turning = "right";
        }
        else if (relativeVector.x < -0.5f)
        {
            turning = "left";
        }
        float dist = Vector2.Distance(transform.position, nextPoint);
        isAccPressed = true;
        if (dist < 2)
        {
            currentIndex++;
            if (currentIndex >= totalWayPoints)
            {
                currentIndex = 0;
            }
            currentWayPoint = route[currentIndex].transform;
            nextPos = false;
        }
    }

    private void FixedUpdate()
    {
        if(driver.isAIMovement)
        {
            driver.Movement(turning, isAccPressed);
        }
    }
}
