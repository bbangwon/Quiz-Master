using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToCompleteQuestion = 30f;
    [SerializeField] float timeToShowCorrectAnswer = 10f;
    
    public bool isAnsweringQuestion = false;
    float timerValue;

    void Update()
    {
        UpdateTimer();
    }

    void UpdateTimer()
    {
        timerValue -= Time.deltaTime;

        if(isAnsweringQuestion)
        {
            if(timerValue <= 0)
            {
                timerValue = timeToShowCorrectAnswer;
                isAnsweringQuestion = false;
            }
        }
        else
        {
            if(timerValue <= 0)
            {
                timerValue = timeToCompleteQuestion;
                isAnsweringQuestion = true;
            }
        }

        Debug.Log(timerValue);
    }
}
