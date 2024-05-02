using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplaySoda : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI soda;

    // Update is called once per frame
    void Update()
    {
        soda.text = "Soda: " + Mathf.FloorToInt(ScoreManager.sodaCounter);
    }
}
