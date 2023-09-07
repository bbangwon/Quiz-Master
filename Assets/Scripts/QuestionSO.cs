using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]
public class QuestionSO : ScriptableObject
{
    [TextArea(2, 6)]
    [SerializeField] string question = "새로운 문제를 여기에 입력하세요";
    [SerializeField] string[] answers = new string[4];
    [SerializeField] int correctAnswerIndex = 0;

    public string GetQuestion()
    {
        return question;
    }
    public string GetAnswer(int index)
    {
        return answers[index];        
    }

    public int GetCorrectAnswerIndex()
    {
        return correctAnswerIndex;
    }
}
