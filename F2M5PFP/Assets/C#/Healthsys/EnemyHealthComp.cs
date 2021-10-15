using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthComp : HealthComp
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Takedamage(5);
        }
    }

    protected override void HandleTakeDamage()
    {
        base.HandleTakeDamage();
        //update healthbar
    }


    protected override void death()
    {
        base.death();
        Destroy(gameObject);
    }
}
