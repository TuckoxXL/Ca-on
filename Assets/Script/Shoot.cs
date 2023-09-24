using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnbullet;
    public LogicCanyon infoBullet;

    public float shootForce = 1500;
    public float shootRate = 0.5f;
    private float shootRatetime = 0;


    public void ShootBallet()
    {
        GameObject bulletCannon = bullet;
        bulletCannon.GetComponent<Rigidbody>().mass = infoBullet.bulletWeight;
        bulletCannon.GetComponent<Bullet>().speed = infoBullet.forceCannon;
        Instantiate(bulletCannon, spawnbullet.position, spawnbullet.rotation);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Time.time > shootRatetime)
            {
                GameObject newbullet;

                newbullet = Instantiate(bullet, spawnbullet.position, spawnbullet.rotation);

                newbullet.GetComponent<Rigidbody>().AddForce(spawnbullet.forward * shootForce);

                shootRatetime = Time.time + shootRate;

                Destroy(newbullet, 3);

            }
        }
    }
}
