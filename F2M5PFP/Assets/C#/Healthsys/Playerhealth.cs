using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerhealth : HealthComp
{
    [SerializeField] private PlayerHealthUI _playerHealthUI;


    private void Start()
    {
        _playerHealthUI.UpdateUI(_Currenthealth);

    }

    protected override void death()
    {
        base.death();
        print("laad level");
    }
    protected override void HandleTakeDamage()
    {
        base.HandleTakeDamage();
        _playerHealthUI.UpdateUI(_Currenthealth);
    }
}
