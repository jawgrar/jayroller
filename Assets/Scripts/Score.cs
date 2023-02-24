using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    private float _timer;

    private void Update()
    {
        _timer += Time.deltaTime;
        scoreText.text = _timer.ToString("0.00");
    }
}
