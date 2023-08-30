using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]
public class QuestionSO : ScriptableObject
{
    [TextArea(2, 6)]
    [SerializeField] string question = "���ο� ������ ���⿡ �Է��ϼ���";

    public string GetQuestion()
    {
        return question;
    }

}
