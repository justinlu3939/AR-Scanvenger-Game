using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayMilk : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI milky;

    // Update is called once per frame
    void Update()
    {
        milky.text = "Milk: " + Mathf.FloorToInt(ScoreManager.milkCounter);
    }
}
