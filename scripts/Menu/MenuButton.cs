using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class MenuButton : MonoBehaviour, IGvrPointerHoverHandler {

  private string MENU_SCENE = "Menu";
  public GameObject fadeEffect;
  public GameObject hideButton;
  public GameObject title;

  IEnumerator ChangeAfter2SecondsCoroutine() {
    fadeEffect.SetActive(true);
    hideButton.SetActive(true);
    Destroy(title);
    yield return new WaitForSeconds(2);
    SceneManager.LoadScene(MENU_SCENE);
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

