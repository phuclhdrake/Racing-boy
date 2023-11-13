using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceDamage : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        string[] aiTags = { "Bullet", "AIBlueBuggy", "AIBlueMonsterTruck", "AIGoKart", "AIGreenMonsterTruck", "Player", "AIPurpleBuggy", "AIRacing", "AITaxi", "AISportCar", "AITaxi", "AITractorCar", };

        if (Array.Exists(aiTags, tag => tag == other.gameObject.tag))
        {
            PoliceHealthManager.instance.DamagePolice();
        }
    }
}
