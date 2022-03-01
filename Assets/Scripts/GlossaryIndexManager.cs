using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DanielLochner.Assets.SimpleScrollSnap; 
public class GlossaryIndexManager : MonoBehaviour
{
    public SimpleScrollSnap scrollSnap;
    public GameObject description, description2;

    public void openedCard()
    {
        description.SetActive(true);
    }
    public void closedCard()
    {
        description.SetActive(false);
    }
    public void openedCard2()
    {
        description2.SetActive(true);
    }
    public void closedCard2()
    {
        description2.SetActive(false);
    }
    public void changeIndex(int index)
    {
        scrollSnap.GoToPanel(index);
    }
}
