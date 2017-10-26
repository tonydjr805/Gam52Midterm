using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CannonController : MonoBehaviour
{
    public float speed = 1.0f;

    public KeyCode fireInput = KeyCode.Space;

    public GameObject laserPrefab = null;
    public GameObject bulletPrefab = null;

    public GameObject[] weaponPlacements = null;

    public float laserFireRate = 0.2f;
    public bool canShoot = true;
    public float laserCooldownTimer = 0.0f;

    public bool canShootbullet = true;
    public float bulletFireRate = 0.2f;
    public float bulletCooldownTimer = 0.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(fireInput))
        {
            //GetComponent< Animation > ().Play("CannonFiring", PlayMode.StopAll);
            if (canShoot == true)
            {
                //source.clip = laser;
                //source.Play();
                // Instantiate(laserPrefab, transform.position, transform.rotation);
                for (int i = 0; i < weaponPlacements.Length; i++)
                {
                    Instantiate(laserPrefab, weaponPlacements[i].transform.position, Quaternion.identity);
                    canShoot = false;
                }
            }
            else
            {
                laserCooldownTimer += Time.deltaTime;
                if (laserCooldownTimer >= laserFireRate)
                {

                    laserCooldownTimer = 0.0f;
                    canShoot = true;

                }
            }
        }

    }
}
