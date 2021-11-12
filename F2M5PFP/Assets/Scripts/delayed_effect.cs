using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delayed_effect : MonoBehaviour
{
    public GameObject wave;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(delayed());
    }

    public IEnumerator delayed()
    {
        yield return new WaitForSeconds(2f);
        Destroy(wave);
        Destroy(gameObject);


    }
}
