using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedoMeter : MonoBehaviour
{
    public Rigidbody2D target;
    public float maxSpeed;
    public float minSpeed, maxSpeedAngle;
    public Text speedLable;
    public RectTransform arrow;
    private float speed;

    void Update()
    {
        speed = target.velocity.magnitude * 3.6f;

        if (speedLable != null)
        {
            speedLable.text = Mathf.FloorToInt(speed * 2.5f) + " km/h";
        }
        if (arrow != null)
        {
            arrow.localEulerAngles = new Vector3 (0, 0, Mathf.Lerp(minSpeed, maxSpeedAngle, speed / maxSpeed));
        }
    }
}
