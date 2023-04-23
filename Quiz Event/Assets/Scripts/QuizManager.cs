using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;
public class QuizManager : MonoBehaviour
{
    public Question[] allQuestions;

    public TextMeshProUGUI[] Answers;
    public AudioClip[] clips;

    public TextMeshProUGUI QuestionText;

    public AudioSource audio;

    private int currentQuestion;
    private int correctAnswerIndex;

    public GameObject panel, mainMenuButton, quizPanel, menuPanel;
    public TextMeshProUGUI paneltext;

    public int scorePoint;
    public TextMeshProUGUI scoreText;


    void Start()
    {
        scorePoint = PlayerPrefs.GetInt("Score");

        menuPanel.SetActive(true);

        SetQuestion();
    }

    
    void Update()
    {
        PlayerPrefs.SetInt("Score", scorePoint);
        scoreText.text = " Skor : " + scorePoint.ToString();

    }

    private void SetQuestion()
    {
        int questionIndex = currentQuestion % allQuestions.Length;

        QuestionText.text = allQuestions[questionIndex].questionText;

        for(int i = 0; i < Answers.Length; i++)
        {
            Answers[i].text = allQuestions[questionIndex].answers[i];
        }

        correctAnswerIndex = allQuestions[questionIndex].correctAnswerIndex;

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
                paneltext.text = "Doğru Cevap!";

                scorePoint += 10;
            }
            else
            {
                audio.PlayOneShot(clips[1]);
                quizPanel.SetActive(false);
                panel.SetActive(true);
                paneltext.color = Color.red;
                paneltext.text = "Yanlış Cevap!";

                scorePoint -= 5;
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
