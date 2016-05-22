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

    protected override void Update()
    {
	    base.Update();
    }

    void FireBullet()
    {
	bulletClone = Instantiate(bullet, bullet.transform.position, Quaternion.identity) as GameObject;
	FireProjectileScript projectileScript = bulletClone.GetComponentInChildren<FireProjectileScript>();
	projectileScript.ProjectileCollisionLayers &= (~UnityEngine.LayerMask.NameToLayer("FriendlyLayer"));

	//bulletClone.transform.parent = null;
	transform.parent = null;
	bulletClone.SetActive(true);
    }
}
