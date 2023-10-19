using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CopShoot : MonoBehaviour
{

    public float radius;
    bool located = false;
    public Transform target;
    Vector2 Drirection;
    public GameObject cop;
    private float nextShot = 0;
    public float fireRate;
    public GameObject bullet;
    public float force;
    public Transform pointOfShot;

    public ParticleSystem muzzleFlash;
    public AudioSource gunSound;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 targetPos = target.position;
        Drirection = targetPos - (Vector2)transform.position;
        RaycastHit2D rayInfo = Physics2D.Raycast(transform.position, Drirection, radius);

        if (rayInfo)
        {
            if (rayInfo.collider.gameObject.tag == "Player")
            {
                if (located == false)
                {
                    located = true;
                }
            }
            else
            {
                if (located == true)
                {
                    located = false;
                }
            }
        }

        if (located)
        {
            cop.transform.up = Drirection;
            if (Time.time > nextShot)
            {
                nextShot = Time.time + 1 / fireRate;
                ShootBullet();
            }
        }
    }

    void ShootBullet()
    {
        GameObject bulletIns = Instantiate(bullet, pointOfShot.position, Quaternion.identity);
        gunSound.Play();
        muzzleFlash.Play();
        bulletIns.GetComponent<Rigidbody2D>().AddForce(Drirection * force);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
