using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CopBulletDestroy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Destroy(this.gameObject);
        gameObject.SetActive(false);
    }

}
