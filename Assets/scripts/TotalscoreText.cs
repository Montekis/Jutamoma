using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalscoreText : MonoBehaviour {


    Text score;

    void OnEnable()
    {
        score = GetComponent<Text>();
        score.text = "Total Score: " + PlayerPrefs.GetInt("TotalScore").ToString();
    }
}
