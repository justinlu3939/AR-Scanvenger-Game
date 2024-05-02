using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FinalScoreScript : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI finalScore;

    // Just need to call this once, no need for continous update
    void Start()
    {
        finalScore.text = "Final Score: " + Mathf.FloorToInt(ScoreManager.scoreCounter);
    }
}
