using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    int score;
    TextMeshProUGUI text;

    void Start()
    {
        text = GetComponent<TMPro.TextMeshProUGUI>();
    }

    public void resetScore(){
        score = 0;
        text.text = score.ToString();
    }

    public void addScore(int amount){
        score += amount;
        text.text = score.ToString();
    }
}
