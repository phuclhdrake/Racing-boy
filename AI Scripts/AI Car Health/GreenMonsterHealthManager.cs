using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenMonsterHealthManager : MonoBehaviour
{
    //
    private static GreenMonsterHealthManager instance;
    public static GreenMonsterHealthManager Instance { get => instance; }

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
    public void DamageGreenMonster()
    {
        currentHealth--;
        if (currentHealth <= 0)
        {
            Instantiate(explosion, transform.position, transform.rotation);
            gameObject.SetActive(false);
            carExplosion.Play();
            //
            GameManager.Instance.KillGreenMonster();
        }
    }

    public void Respawn()
    {
        gameObject.SetActive(true);
        currentHealth = maxHealth;
    }
}
