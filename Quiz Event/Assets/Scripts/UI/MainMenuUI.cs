using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    public RectTransform[] downYTransforms;
    public TextMeshProUGUI TitleText;

    private void OnEnable()
    {
        foreach (RectTransform downYTransform in downYTransforms)
        {
            downYTransform.DOAnchorPosY(-700f, 1f).From();
        }

        TitleText.DOColor(Color.white,  1.5f).SetDelay(1f);
    }

    public void OnClickTween(RectTransform rectTransform)
    {
        rectTransform.DOScale(rectTransform.localScale * 1.25f, 1f / 3f).SetLoops(2, LoopType.Yoyo);
    }
}
