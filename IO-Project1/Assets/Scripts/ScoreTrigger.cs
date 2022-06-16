using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTrigger : MonoBehaviour
{
    private Text score;

    private void Start()
    {
        score = Text.FindObjectOfType<Text>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            int intScore = int.Parse(score.text) + 1;
            score.text = intScore.ToString();
        }

    }

}
