using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]
public class QuestionSO : ScriptableObject
{
    [TextArea(2, 6)]
    [SerializeField] string question = "새로운 문제를 여기에 입력하세요";

    public string GetQuestion()
    {
        return question;
    }

}
