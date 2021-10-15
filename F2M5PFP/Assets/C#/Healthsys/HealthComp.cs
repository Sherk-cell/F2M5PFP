using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthComp : MonoBehaviour
{
    [SerializeField] private float Starthealth;
    private float Currenthealth;
    public float _Currenthealth
    {
        get { return Currenthealth; }
    }


    private void Awake()
    {
        Currenthealth = Starthealth;
    }
    
    public void Takedamage(float amount)
    {
        Currenthealth -= amount;
        HandleTakeDamage();
        
        if (Currenthealth <= 0)
        {
            death();

        }
       
    }

    protected virtual void HandleTakeDamage()
    {
        print("ik krijg damage");
    }


    protected virtual void death()
    {
        print("dead");
        Destroy(gameObject);

    }


}
