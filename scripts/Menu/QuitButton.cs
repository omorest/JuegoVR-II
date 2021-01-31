using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class QuitButton : MonoBehaviour, IGvrPointerHoverHandler {

  public GameObject fadeEffect;
  public GameObject hideButton;
  public GameObject otherButton;
  public GameObject title;

  IEnumerator ChangeAfter2SecondsCoroutine() {
    fadeEffect.SetActive(true);
    hideButton.SetActive(true);
    Destroy(otherButton);
    Destroy(title);
    yield return new WaitForSeconds(2);
    Application.Quit();
  }

  public void Start() {
    ResetColor();
  }

  public void OnGvrPointerHover(PointerEventData eventData) {
    GetComponent<Renderer>().material.color = Color.red;
    if (Input.GetButtonDown("Fire1")) {
      StartCoroutine(ChangeAfter2SecondsCoroutine());
    }
  }

  public void ResetColor() {
    GetComponent<Renderer>().material.color = Color.blue;
  }
}