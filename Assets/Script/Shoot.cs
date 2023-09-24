using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnbullet;
    public LogicCanyon infoBullet;

    public void ShootBallet()
    {
        GameObject bulletCannon = bullet;
        bulletCannon.GetComponent<Rigidbody>().mass = infoBullet.bulletWeight;
        bulletCannon.GetComponent<Bullet>().speed = infoBullet.forceCannon;
        Instantiate(bulletCannon, spawnbullet.position, spawnbullet.rotation);
    }
    private void Start()
    {
        ShootBallet();
    }
}
