using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BublController : MonoBehaviour
{
   
   
    void Update()
    {
        transform.Rotate(Vector3.forward, 0.5f);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GetComponent<AudioSource>().Play();
            transform.position = new Vector3(1000, 1000, 1000);
            WallSpeedController.WallSpeed = 0;
            StartCoroutine(causeDelay());

        }

    }
   
    IEnumerator causeDelay()
    {
        yield return new WaitForSeconds(5);
        WallSpeedController.WallSpeed = 0.5f;
        Destroy(gameObject);
    }
}
