using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayMeat : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI meaty;

    // Update is called once per frame
    void Update()
    {
        meaty.text = "Meat: " + Mathf.FloorToInt(ScoreManager.meatCounter);
    }
}
