using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueMonsterHealthManager : MonoBehaviour
{
    public static BlueMonsterHealthManager instance;
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
    public void DamageBlueMonster()
    {
        currentHealth--;
        if (currentHealth <= 0)
        {
            Instantiate(explosion, transform.position, transform.rotation);
            gameObject.SetActive(false);
            carExplosion.Play();

            GameManager.instance.KillBlueMonster();
        }
    }

    public void Respawn()
    {
        gameObject.SetActive(true);
        currentHealth = maxHealth;
    }
}
