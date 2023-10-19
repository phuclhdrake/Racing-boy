using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{
    private bool isCollEmemy = true;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (isCollEmemy)
        {
            string[] aiTags = { "AIBlueBuggy", "AIBlueMonsterTruck", "AIGoKart", "AIGreenMonsterTruck", "AIPolice", "AIPurpleBuggy", "AIRacing", "AITaxi", "AISportCar", "AITaxi", "AITractorCar" };

            if (Array.Exists(aiTags, tag => tag == other.gameObject.tag))
            {
                HealthManager.Instance.DamagePlayer();
                isCollEmemy = false;
                StartCoroutine(isColl());
            }
        }
    }

    IEnumerator isColl()
    {
        yield return new WaitForSeconds(0.5f);
        Debug.Log("ppp");
        isCollEmemy = true;
    }
}
