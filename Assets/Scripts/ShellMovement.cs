using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class ShellMovement : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * 50;
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Hazard")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
