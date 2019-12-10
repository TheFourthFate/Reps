using System.Collections;
using System;
using UnityEngine;

public class Friend : MonoBehaviour
{
    bool playerInRange;
    public GameObject effect;

    public event Action wave;
    private bool waving;
    float waveDuration = 1f;
    void Start()
    {
        
    }


    void Update()
    {
        Wave();
    }
    public void Wave()
    {
        if (playerInRange == true)
        {
            if (Input.GetKey(KeyCode.Space))
            {

                StartCoroutine(Waveing());
                Instantiate(effect, transform.position, Quaternion.identity);
                Destroy(this.gameObject);
            }
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerInRange = true;
            Debug.Log("inBound");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            playerInRange = false;
            Debug.Log("Out of reach");
        }
    }
    private IEnumerator Waveing()
    {
        wave?.Invoke();
        waving = true;
        yield return new WaitForSeconds(waveDuration);

        waving = false;
    }

}
