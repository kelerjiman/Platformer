using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flower_Rounding : MonoBehaviour
{
    [SerializeField] List<RectTransform> positions;
    [SerializeField]RectTransform rectTransform;
    Animator animator;
    [SerializeField] float fadeTime = 1f;
    private void Start()
    {
        //animator = GetComponent<Animator>();
        //ChangePosition();
    }
    public void ChangePosition()
    {
        Debug.Log(positions[Random.Range(0, positions.Count)].anchoredPosition);
        Debug.Log(rectTransform.anchoredPosition);
        rectTransform.anchoredPosition = positions[Random.Range(0, positions.Count)].anchoredPosition;
        StartCoroutine(FadeIn());    
    }
    IEnumerator FadeOut()
    {
        animator.Play("FadeOut");
        yield return new WaitForSeconds(fadeTime);
        ChangePosition();
    }
    IEnumerator FadeIn()
    {
        animator.Play("FadeIn");
        yield return new WaitForSeconds(fadeTime);
        StartCoroutine(FadeOut());
    }
}
