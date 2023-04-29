using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class NavMeshMovement : MonoBehaviour
{
    public GameObject[] obstacle;
    private UnityEngine.AI.NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        obstacle = GameObject.FindGameObjectsWithTag("Hazard");
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.destination = obstacle[Random.Range(0,obstacle.Length)].transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Hazard")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}