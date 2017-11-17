using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : Player {


    protected override void Update()
    {
        base.Update();
        Move(5f);

    }

    public override void Effect()
    {
        Debug.Log("Ralenti");
        Time.timeScale = 0.3f;
        StartCoroutine(Timer());
        
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(0.5f);
        Time.timeScale = 1f;
    }
}
