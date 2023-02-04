using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class QuestionMenuUI : MonoBehaviour
{
    public RectTransform[] downYTransforms;
    public RectTransform[] upYTransforms;
    public RectTransform[] scaleTransforms;

    private void OnEnable()
    {
        foreach (RectTransform scaleTransform in scaleTransforms)
        {
            scaleTransform.DOScale(Vector3.zero, 1f).From();
        }

        foreach (RectTransform downYTransform in downYTransforms)
        {
            downYTransform.DOAnchorPosY(-700f, 1f).From();
        }

        foreach (RectTransform upYTransform in upYTransforms)
        {
            upYTransform.DOAnchorPosY(700f, 1f).From();
        }
    }

    public void OnClickTween(RectTransform rectTransform)
    {
        rectTransform.DOScale(rectTransform.localScale * 1.25f, 1f / 3f).SetLoops(2, LoopType.Yoyo);
    }
}
