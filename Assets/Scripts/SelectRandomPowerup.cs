using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Security.Principal;
using UnityEngine;

public class SelectRandomPowerup : MonoBehaviour
{
    public List<GameObject> powerupList;
    public int randomNumberInList;
    public GameObject chosenPowerup;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space") && chosenPowerup)
        {
            Instantiate(
               chosenPowerup,
               new Vector3(
                   transform.position.x,
                   transform.position.y,
                   transform.position.z + -5),
                   transform.rotation);
            chosenPowerup = null;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "itemBoxes")
        {
            randomNumberInList = Random.Range(0, powerupList.Count);
            chosenPowerup = powerupList[randomNumberInList];
        }
    }
}
