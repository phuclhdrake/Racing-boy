using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{
    private Vector3 angle;
    public float wheelAngle, maxWheelAngle = 30f;

    void Update()
    {
        wheelAngle = -Input.GetAxis("Horizontal") * maxWheelAngle;
    }

    private void LateUpdate()
    {
        angle = transform.localEulerAngles;
        angle.z = wheelAngle;
        transform.localEulerAngles = angle;
    }
}
