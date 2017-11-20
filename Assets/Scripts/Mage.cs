using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : Player {

    private float _startSpeed;

    protected override void Update()
    {
        base.Update();
        Move(5f);

    }

    public override void Effect()
    {
        _startSpeed = ball.speed;
        ball.speed = ball.speed / 2;
        StartCoroutine(Timer());
        
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(2f);
        ball.speed = _startSpeed;
    }
}
