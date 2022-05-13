using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public GameObject ball;
    private Vector3 offset = new Vector3(7.5f, 7.5f, 0.5f);


    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = ball.transform.position + offset;
    }
}
