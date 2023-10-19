using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TractorDamage : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        string[] aiTags = { "Bullet", "AIBlueBuggy", "AIBlueMonsterTruck", "AIGoKart", "AIGreenMonsterTruck", "AIPolice", "AIPurpleBuggy", "AIRacing", "AITaxi", "AISportCar", "AITaxi", "Player", };

        if (Array.Exists(aiTags, tag => tag == other.gameObject.tag))
        {
            TractorHealthManager.instance.DamageTractor();
        }
    }
}
