using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeTextDisplay : MonoBehaviour
{
    GameManager gameManager;
    TextMeshProUGUI timeText;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
       timeText = GetComponent<TextMeshProUGUI>();
    }

    //Update is called once per frame
    /***
    void Update()
    {
        if (gameManager.IsGameover)
        {
            gameManager.SurviveTime += Time.deltaTime;
            timeText.text = "Time: " + gameManager.SurviveTime.ToString();
        }
    }
    ***/
}
