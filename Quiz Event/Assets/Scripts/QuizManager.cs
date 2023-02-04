using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class QuizManager : MonoBehaviour
{
    [Header("Main")]
    public Question[] questions;
    public TextMeshProUGUI[] Answers;
    public AudioClip[] clips;

    public TextMeshProUGUI QuestionText;

    public AudioSource audio;

    private int currentQuestion;
    private int correctAnswerIndex;

    [Header("Panel")]
    public GameObject panel, mainMenuButton, quizPanel, menuPanel;
    public TextMeshProUGUI paneltext;

    void Start()
    {
        menuPanel.SetActive(true);
        SetQuestion();
    }

    
    void Update()
    {
        //81YusufBrn98a766
    }

    private void SetQuestion()
    {
        int questionIndex = currentQuestion % questions.Length;

        QuestionText.text = questions[questionIndex].questionText;

        for(int i = 0; i < Answers.Length; i++)
        {
            Answers[i].text = questions[questionIndex].answers[i];
        }

        correctAnswerIndex = questions[questionIndex].correctAnswerIndex;

        currentQuestion ++;
    }

    public void AnswerButton(int answerIndex)
    {
        audio.PlayOneShot(clips[2]);

        StartCoroutine(checkAnswer());


        IEnumerator checkAnswer()
        {
            yield return new WaitForSeconds(1.8f);

            if (answerIndex == correctAnswerIndex)
            {
                audio.PlayOneShot(clips[0]);
                quizPanel.SetActive(false);
                panel.SetActive(true);
                paneltext.color = Color.green;
                paneltext.text = "Doðru Cevap!";
            }
            else
            {
                audio.PlayOneShot(clips[1]);
                quizPanel.SetActive(false);
                panel.SetActive(true);
                paneltext.color = Color.red;
                paneltext.text = "Yanlýþ Cevap!";
            }
        }
    }



    public void PlayGame()
    {
        menuPanel.SetActive(false);
        quizPanel.SetActive(true);
    }
    public void PauseGame()
    {
        panel.SetActive(false);
        quizPanel.SetActive(false);
        menuPanel.SetActive(true);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void ClosePanel()
    {
        panel.SetActive(false);
        quizPanel.SetActive(true);
        SetQuestion();
    }
}
