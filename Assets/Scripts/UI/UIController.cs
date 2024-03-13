using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
     public GameObject fadePanel;

     public IEnumerator FadeOutCanvas(bool fadeToBlack = true, int fadeSpeed = 5)
     {
          Color canvasColor = fadePanel.GetComponent<Image>().color;
          float fadeAmount;

          if (fadeToBlack)
          {
               while (fadePanel.GetComponent<Image>().color.a < 1)
               {
                    fadeAmount = canvasColor.a + (fadeSpeed * Time.deltaTime);

                    canvasColor = new Color(canvasColor.r, canvasColor.g, canvasColor.b, fadeAmount);
                    fadePanel.GetComponent<Image>().color = canvasColor;
                    yield return null; 
               }
          }
     }
}
