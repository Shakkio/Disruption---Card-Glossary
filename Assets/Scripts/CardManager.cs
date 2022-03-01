using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    int realIndex;
    public void zoomCard(int index)
    {
        realIndex = index % 5;
        StopAllCoroutines();
        StartCoroutine(zoom(realIndex));
    }

    public void dezoomCard(int index)
    {
        realIndex = index % 5;
        StopAllCoroutines();
        StartCoroutine(dezoom(realIndex));
    }

    IEnumerator zoom(int index)
    {
        float timer = 0;
        while(timer <= 1)
        {
            timer += Time.deltaTime;
            timer = Mathf.Clamp(timer, 0f, 1f);
            switch(index)
            {
                case 0:
                    transform.SetSiblingIndex(1);
                    GetComponent<RectTransform>().sizeDelta = Vector2.Lerp(GetComponent<RectTransform>().sizeDelta, new Vector2(858, 858), timer);
                    GetComponent<RectTransform>().anchoredPosition = Vector2.Lerp(GetComponent<RectTransform>().anchoredPosition, new Vector2(-24, -22), timer);
                    yield return null;
                    break;
                case 1:
                    GetComponent<RectTransform>().sizeDelta = Vector2.Lerp(GetComponent<RectTransform>().sizeDelta, new Vector2(858, 858), timer);
                    GetComponent<RectTransform>().anchoredPosition = Vector2.Lerp(GetComponent<RectTransform>().anchoredPosition, new Vector2(3, 8), timer);
                    yield return null;
                    break;
                case 2:
                    GetComponent<RectTransform>().sizeDelta = Vector2.Lerp(GetComponent<RectTransform>().sizeDelta, new Vector2(858, 858), timer);
                    GetComponent<RectTransform>().anchoredPosition = Vector2.Lerp(GetComponent<RectTransform>().anchoredPosition, new Vector2(46, 16), timer);
                    yield return null;
                    break;
                case 3:
                    transform.SetSiblingIndex(4);
                    GetComponent<RectTransform>().sizeDelta = Vector2.Lerp(GetComponent<RectTransform>().sizeDelta, new Vector2(858, 858), timer);
                    GetComponent<RectTransform>().anchoredPosition = Vector2.Lerp(GetComponent<RectTransform>().anchoredPosition, new Vector2(961, 8), timer);
                    yield return null;
                    break;
                case 4:
                    GetComponent<RectTransform>().sizeDelta = Vector2.Lerp(GetComponent<RectTransform>().sizeDelta, new Vector2(858, 858), timer);
                    GetComponent<RectTransform>().anchoredPosition = Vector2.Lerp(GetComponent<RectTransform>().anchoredPosition, new Vector2(1024, 14), timer);
                    yield return null;
                    break;
            }
        }
    }
    IEnumerator dezoom(int index)
    {
        float timer = 0;
        while(timer <= 1f)
        {
            timer += Time.deltaTime;
            timer = Mathf.Clamp(timer, 0f, 1f);
            switch(index)
            {
                case 0:
                    transform.SetSiblingIndex(0);
                    GetComponent<RectTransform>().sizeDelta = Vector2.Lerp(GetComponent<RectTransform>().sizeDelta, new Vector2(500, 500), timer);
                    GetComponent<RectTransform>().anchoredPosition = Vector2.Lerp(GetComponent<RectTransform>().anchoredPosition, new Vector2(49, 0), timer);
                    yield return null;
                    break;
                case 1:
                    GetComponent<RectTransform>().sizeDelta = Vector2.Lerp(GetComponent<RectTransform>().sizeDelta, new Vector2(500, 500), timer);
                    GetComponent<RectTransform>().anchoredPosition = Vector2.Lerp(GetComponent<RectTransform>().anchoredPosition, new Vector2(380, 8), timer);
                    yield return null;
                    break;
                case 2:
                    GetComponent<RectTransform>().sizeDelta = Vector2.Lerp(GetComponent<RectTransform>().sizeDelta, new Vector2(500, 500), timer);
                    GetComponent<RectTransform>().anchoredPosition = Vector2.Lerp(GetComponent<RectTransform>().anchoredPosition, new Vector2(718, 16), timer);
                    yield return null;
                    break;
                case 3:
                    transform.SetSiblingIndex(3);
                    GetComponent<RectTransform>().sizeDelta = Vector2.Lerp(GetComponent<RectTransform>().sizeDelta, new Vector2(500, 500), timer);
                    GetComponent<RectTransform>().anchoredPosition = Vector2.Lerp(GetComponent<RectTransform>().anchoredPosition, new Vector2(1059, 8), timer);
                    yield return null;
                    break;
                case 4:
                    GetComponent<RectTransform>().sizeDelta = Vector2.Lerp(GetComponent<RectTransform>().sizeDelta, new Vector2(500, 500), timer);
                    GetComponent<RectTransform>().anchoredPosition = Vector2.Lerp(GetComponent<RectTransform>().anchoredPosition, new Vector2(1397, 14), timer);
                    yield return null;
                    break;
            }
        }
    }
}
