using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWall : MonoBehaviour
{
    public float speed;
    private void Start()
    {
        speed = 0.5f;
    }
    void Update()
    {
        speed = WallSpeedController.WallSpeed;
      
        if (CompareTag("IncreaseX") )
            transform.position += new Vector3((speed) * Time.deltaTime, 0, 0);
        if (CompareTag("DecreaseX"))
            transform.position -= new Vector3(( speed) * Time.deltaTime, 0, 0);
        if (CompareTag("IncreaseZ"))
            transform.position += new Vector3(0, 0, (speed) * Time.deltaTime);
        if (CompareTag("DecreaseZ"))
            transform.position -= new Vector3(0, 0, (speed) * Time.deltaTime);
    }
}
