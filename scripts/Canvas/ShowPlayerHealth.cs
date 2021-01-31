using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowPlayerHealth : MonoBehaviour {
  public Image health;
  private PlayerLifeSystem playerLifeSystem;
  
  private void Start() {
    playerLifeSystem = GameObject.FindWithTag("PlayerTag").GetComponent<PlayerLifeSystem>();
  }

  private void Update() {
    health.fillAmount = playerLifeSystem.GetLife() / 100.0f;
  }
}
