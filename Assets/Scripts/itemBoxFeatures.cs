using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class itemBoxFeatures : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(100, 100, 100), Time.deltaTime * 100);
    }

    void OnCollisionEnter(Collision collision)
    {
        gameObject.SetActive(false);
        Invoke("itemBoxRespawn", 3.0f);
    }

    private void itemBoxRespawn()
    {
        gameObject.SetActive(true);
    }
}