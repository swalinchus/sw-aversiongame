using UnityEngine;
using TMPro;

public class ScoreCount : MonoBehaviour
{
    public float timer;
    private float score;
    public TMP_Text text;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = 0;
        text = GetComponent<TMP_Text>();
        text.text = "SCORE: 0";
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        score = Mathf.Floor(timer) * 5;
        text.text = "SCORE: " + score;
    }
}
