using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerFinishLine : MonoBehaviour
{
    public CheckpointCounter checkpointTracker;

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if(checkpointTracker.triggeredCheckpoints == checkpointTracker.numberOfCheckpoints)
            {
                SceneManager.LoadScene(1);
            }
            else
            {
                SceneManager.LoadScene(3);
                Application.OpenURL("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
            }
        }
    }
}
