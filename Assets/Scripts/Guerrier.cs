using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guerrier : Player {

    public bool SpellCD = false;
    protected override void Update()
    {
        base.Update();
        Move(3f);
       
    }

    public override void Effect()
    {
        if (!SpellCD)
        {
            SpellCD = true;
            _Multiplicateur = 1.5f;
            StartCoroutine(TimerSpell());
        }

       
    }

    IEnumerator TimerSpell()
    {
        _Multiplicateur = 1.5f;
        yield return new WaitForSeconds(3f);
        _Multiplicateur = 1.1f;
        yield return new WaitForSeconds(3f);
        SpellCD = false;
    }
    
}
