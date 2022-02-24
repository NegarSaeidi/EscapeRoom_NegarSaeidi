using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWall : MonoBehaviour
{
    public float speed;
   
    void Update()
    {
        if (CompareTag("IncreaseX") || CompareTag("DecreaseX"))
            transform.position += new Vector3(( speed) * Time.deltaTime, 0, 0);
        if (CompareTag("IncreaseZ") || CompareTag("DecreaseZ"))
            transform.position += new Vector3(0, 0, (speed) * Time.deltaTime);
    }
}
