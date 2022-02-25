using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowManController : MonoBehaviour
{
    
   
    void Update()
    {
        transform.Rotate(Vector3.up, 0.5f);
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            JimmyAniamtion.snowmanHit = true;
            WallSpeedController.WallSpeed = 5;
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
