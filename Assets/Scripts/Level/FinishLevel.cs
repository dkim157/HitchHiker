using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class FinishLevel : MonoBehaviour
{

     public GameObject UICanvas;
     public TMP_Text displayText;

     [SerializeField] private string _nextLevel;
     private GameObject _fadePanel;
     private UIController _uicontroller;
     private readonly string _levelCompleteText = "LEVEL COMPLETE";

     private void Start()
     {
          _fadePanel = UICanvas.transform.Find("FadePanel").gameObject;
          _uicontroller = UICanvas.GetComponent<UIController>();
     }

     private void OnTriggerEnter(Collider other)
     {
          if (other.CompareTag("Player"))
          {
               StartCoroutine(FinishLevelRoutine());
          }
     }

     private IEnumerator FinishLevelRoutine()
     {
          displayText.text = _levelCompleteText;

          yield return StartCoroutine(_uicontroller.FadeOutCanvas());

          yield return new WaitForSeconds(5);

          SceneManager.LoadScene(_nextLevel);
     }
}