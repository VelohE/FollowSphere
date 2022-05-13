using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cam1;
    public GameObject cam2;
    public float wait = 5f;
    void Start()
    {
        cam2.SetActive(false);
        StartCoroutine(SwitchCamera());
    }
    private IEnumerator SwitchCamera()
    {
        yield return new WaitForSeconds(wait);
        cam1.SetActive(false);
        cam2.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("key1"))
        {
            cam1.SetActive(true);
            cam2.SetActive(false);
            
        }
        if (Input.GetButtonDown("key2"))
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
        }
          
    }
}
