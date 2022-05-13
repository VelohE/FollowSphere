using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBall : MonoBehaviour
{
    public GameObject ball;
    private Vector3 offset = new Vector3(10.0f, 2.0f, 0.5f);
 

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = ball.transform.position + offset;
    }
}
