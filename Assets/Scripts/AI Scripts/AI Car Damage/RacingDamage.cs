using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacingDamage : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        string[] aiTags = { "Bullet", "AIBlueBuggy", "AIBlueMonsterTruck", "AIGoKart", "AIGreenMonsterTruck", "AIPolice", "AIPurpleBuggy", "Player", "AITaxi", "AISportCar", "AITaxi", "AITractorCar", };

        if (Array.Exists(aiTags, tag => tag == other.gameObject.tag))
        {
            RacingHealthManager.instance.DamageRacing();
        }
    }
}
