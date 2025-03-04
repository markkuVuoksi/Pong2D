using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreTextPaddle1;
    public TextMeshProUGUI scoreTextPaddle2;
    private int scorePaddle1 = 0;
    private int scorePaddle2 = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateScoreDisplay();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScorePaddle1()
    {
        scorePaddle1++;
        UpdateScoreDisplay();
    }

    public void AddScorePaddle2()
    {
        scorePaddle2++;
        UpdateScoreDisplay();
    }

    private void UpdateScoreDisplay()
    {
        scoreTextPaddle1.text = scorePaddle1.ToString();
        scoreTextPaddle2.text = scorePaddle2.ToString();
    }
}
