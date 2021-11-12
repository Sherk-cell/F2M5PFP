using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinalTarget : MonoBehaviour
{
    public float health = 50f;
    public void TakeDamge(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            deaded();
        }


        void deaded()
        {
            Debug.Log("works");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
            Destroy(gameObject);
        }
    }
}
