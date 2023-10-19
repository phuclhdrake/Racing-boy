using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleBuggyHealthManager : MonoBehaviour
{
    private static PurpleBuggyHealthManager instance;
    public static PurpleBuggyHealthManager Instance { get => instance; }

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
    public void DamagePurpleBuggy()
    {
        currentHealth--;
        if (currentHealth <= 0)
        {
            Instantiate(explosion, transform.position, transform.rotation);
            gameObject.SetActive(false);
            carExplosion.Play();
            //
            GameManager.Instance.KillPurpleBuggy();
        }
    }

    public void Respawn()
    {
        gameObject.SetActive(true);
        currentHealth = maxHealth;
    }
}
