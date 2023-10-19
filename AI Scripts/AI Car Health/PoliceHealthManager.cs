using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceHealthManager : MonoBehaviour
{
    //
    private static PoliceHealthManager instance;
    public static PoliceHealthManager Instance { get => instance; }


    public int currentHealth;
    public int maxHealth;
    public GameObject explosion;

    public AudioSource carExplosion;
    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        currentHealth = maxHealth;
    }
    //
    public void DamagePolice()
    {
        currentHealth--;
        if (currentHealth <= 0)
        {
            Instantiate(explosion, transform.position, transform.rotation);
            gameObject.SetActive(false);
            carExplosion.Play();
            //
            GameManager.Instance.KillPolice();
        }
    }

    public void Respawn()
    {
        gameObject.SetActive(true);
        currentHealth = maxHealth;
    }
}
