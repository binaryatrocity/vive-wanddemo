using UnityEngine;
using System.Collections;

public class Wand : SteamVR_InteractableObject
{
    GameObject selectedSpell;
    GameObject spellClone;
    public float spellSpeed = 1000f;
    public float spellOffset = -0.5f;

    public override void StartUsing(GameObject usingObject)
    {
        base.StartUsing(usingObject);
        CastSpell();
    }

    protected override void Start()
    {
        base.Start();
        selectedSpell = this.transform.Find("Spell_Fireball").gameObject;
    }

    protected override void Update()
    {
	    base.Update();
    }

    void CastSpell()
    {
	spellClone = Instantiate(selectedSpell, transform.position, Quaternion.identity) as GameObject;
	SpellController spellController = spellClone.GetComponent<SpellController>();
	spellController.startPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z + spellOffset);
	spellController.startDirection = transform.up;

	spellClone.SetActive(true);

    }
}
