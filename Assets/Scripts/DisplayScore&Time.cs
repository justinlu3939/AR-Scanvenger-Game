using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DisplayScore : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI score;

    [SerializeField]
    public TextMeshProUGUI timer;

    public float scoreCount;

    // Update is called once per frame
    void Update()
    {
        scoreCount = ScoreManager.scoreCounter;
        score.text = "Score: " + Mathf.FloorToInt(scoreCount);
        ScoreManager.time -= Time.deltaTime;
        timer.text = "Time: " + Mathf.FloorToInt(ScoreManager.time) + " seconds.";

        if(ScoreManager.time < 0)
        {
            SceneManager.LoadSceneAsync(3);
        }
        if(ScoreManager.scoreCounter < 0)
        {
            SceneManager.LoadSceneAsync(3);
        }
    }
}
