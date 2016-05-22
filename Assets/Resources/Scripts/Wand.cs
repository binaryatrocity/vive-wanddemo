using UnityEngine;
using System.Collections;
using DigitalRuby.PyroParticles;

public class Wand : SteamVR_InteractableObject
{
    GameObject bullet;
    GameObject bulletClone;

    public override void StartUsing(GameObject usingObject)
    {
        base.StartUsing(usingObject);
        FireBullet();
    }

    protected override void Start()
    {
        base.Start();
        bullet = this.transform.Find("Firebolt").gameObject;
    }

    void FireBullet()
    {
	bulletClone = Instantiate(bullet, bullet.transform.position, Quaternion.identity) as GameObject;
	bulletClone.transform.parent = null;
	bulletClone.SetActive(true);
    }
}
