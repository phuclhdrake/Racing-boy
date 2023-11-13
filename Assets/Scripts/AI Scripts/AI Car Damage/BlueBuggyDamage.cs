using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBuggyDamage : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        string[] aiTags = { "Bullet", "Player", "AIBlueMonsterTruck", "AIGoKart", "AIGreenMonsterTruck", "AIPolice", "AIPurpleBuggy", "AIRacing", "AITaxi", "AISportCar", "AITaxi", "AITractorCar", };

        if (Array.Exists(aiTags, tag => tag == other.gameObject.tag))
        {
            BlueBuggyHealthManager.instance.DamageBlueBuggy();
        }
    }
}
