using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TextEvent : MonoBehaviour
{
    public UnityEvent message;
    [SerializeField] private Text messagetext;
    public GameObject completeLevelUI;

    private void OnTriggerEnter(Collider other)
    {
        message.Invoke();
    }

   public void item()
    {
        completeLevelUI.SetActive(true);
        messagetext.text = "You should know something...";
    }
}
