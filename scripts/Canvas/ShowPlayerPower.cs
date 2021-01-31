using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowPlayerPower : MonoBehaviour {
  public Image power;
  private PlayerLifeSystem player;
  
  private void Start() {
    player = GameObject.FindWithTag("PlayerTag").GetComponent<PlayerLifeSystem>();
  }

  private void Update() {
    power.fillAmount = player.GetBulletDamage() / 100.0f;
  }
}
