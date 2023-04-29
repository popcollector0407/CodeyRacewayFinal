using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimersCountdown : MonoBehaviour
{
    public Text lapTime;
    public Text startCountdown;

    public float totalLapTime;
    public float totalCountdownTime;
    public CodeyMove codey;

    // Update is called once per frame
    void Update()
    {

        if(totalCountdownTime > 0)
        {
            totalCountdownTime -= Time.deltaTime;
            startCountdown.text = totalCountdownTime.ToString();
            codey.Speed = 0;
        }

        if (totalCountdownTime <= 0)
        {
            startCountdown.text = "";
            totalLapTime -= Time.deltaTime;
            lapTime.text = totalLapTime.ToString();
            if (!codey.running)
            {
                codey.Speed = 1750;
            }
        }
        if (totalLapTime < 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}
