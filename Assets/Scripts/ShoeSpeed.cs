using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoeSpeed : MonoBehaviour
{
    public CodeyMove codey;

    void Update()
    {

    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Shoe")
        {
            StartCoroutine(SpeedBoost());
            Destroy(other.gameObject);
        }
    }

    IEnumerator SpeedBoost()
    {
        codey.running = true;
        yield return new WaitForSeconds(5);
        codey.running = false;
    }
}