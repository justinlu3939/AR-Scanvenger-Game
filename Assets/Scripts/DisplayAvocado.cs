using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayAvocado : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI avocado;

    // Update is called once per frame
    void Update()
    {
        avocado.text = "Avocado: " + Mathf.FloorToInt(ScoreManager.avCounter);
    }
}