using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaxiDamage : MonoBehaviour
{
    private bool isCollEmemy = true;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (isCollEmemy)
        {
            string[] aiTags = { "AIBlueBuggy", "AIBlueMonsterTruck", "AIGoKart", "AIGreenMonsterTruck", "AIPolice", "AIPurpleBuggy", "AIRacing", "AITaxi", "AISportCar", "Player", "AITractorCar", };

            if (Array.Exists(aiTags, tag => tag == other.gameObject.tag))
            {
                TaxiHealthManager.Instance.DamageTaxi();
                isCollEmemy = false;
                
                if (gameObject.activeSelf)
                {
                    StartCoroutine(isColl());
                }
            }
        }
    }

    private IEnumerator isColl()
    {
        yield return new WaitForSeconds(0.5f);
        Debug.Log("aaa");
        isCollEmemy = true;
    }
}
