using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacingHealthManager : MonoBehaviour
{
    private static RacingHealthManager instance;
    public static RacingHealthManager Instance { get => instance; }


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
    public void DamageRacing()
    {
        currentHealth--;
        if (currentHealth <= 0)
        {
            Instantiate(explosion, transform.position, transform.rotation);
            gameObject.SetActive(false);
            carExplosion.Play();
            GameManager.Instance.KillRacing();
        }
    }

    public void Respawn()
    {
        gameObject.SetActive(true);
        currentHealth = maxHealth;
    }
}
