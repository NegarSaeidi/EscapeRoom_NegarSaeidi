using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MoveWall : MonoBehaviour
{
    public float speed;
    public GameObject player;
    public GameObject warning;
    private void Start()
    {
        speed = 0.5f;
    }
    void Update()
    {
        if ((JimmyAniamtion.lose) || (JimmyAniamtion.win))
        {
            warning.GetComponent<TextMeshProUGUI>().text = "";
        }
        else
        {
            if (!JimmyAniamtion.inPause)
            {
                speed = WallSpeedController.WallSpeed;
                if (CompareTag("IncreaseX"))
                {
                    int min = (int)calculateDistance() / 60;
                    int sec = (int)calculateDistance() % 60;
                    if (speed > 0)
                        warning.GetComponent<TextMeshProUGUI>().text = min.ToString() + " : " + sec.ToString();
                    else
                        warning.GetComponent<TextMeshProUGUI>().text = "Walls won't be moving for 5 seconds";

                }
                if (CompareTag("IncreaseX"))
                    transform.position += new Vector3((speed) * Time.deltaTime, 0, 0);
                if (CompareTag("DecreaseX"))
                    transform.position -= new Vector3((speed) * Time.deltaTime, 0, 0);
                if (CompareTag("IncreaseZ"))
                    transform.position += new Vector3(0, 0, (speed) * Time.deltaTime);
                if (CompareTag("DecreaseZ"))
                    transform.position -= new Vector3(0, 0, (speed) * Time.deltaTime);
            }
        }
    }
    private float calculateDistance()
    {
        float distance = Vector3.Magnitude(player.transform.position - transform.position);
        float vel = speed * 1.2f;
        return distance / (vel);
    }
}
