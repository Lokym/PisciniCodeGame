using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guerrier : Player {


    protected override void Update()
    {
        base.Update();
        Move(3f);
       
    }

    public override void Effect()
    {

        _Multiplicateur = 2f;
    }

    
}
