using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Target : MonoBehaviour
{
    public float health = 50f;
    [SerializeField] bool Final;
    public void TakeDamge (float amount)
    {
       
        health -= amount;
        if(health <= 0f)
        {
            deaded();
        }


        void deaded()
        {
            if(Final == true)
            {
                Debug.Log("works");
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
                Destroy(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
           
        }
    }
}
