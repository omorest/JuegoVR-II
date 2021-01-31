using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonLifeSystem : MonoBehaviour {
  private DelegateController controller;

  private int INITIAL_LIFE = 250;
  private int LIFE_FACTOR = 100;
  
  private int life;
  private bool isDead;

  void OnEnable() {
    controller.getEnemyDamageEvent += DecreaseLife;
  }

  void OnDeseable() {
    controller.getEnemyDamageEvent -= DecreaseLife;
  }

  void Awake() {
    controller = GameObject.FindWithTag("CameraRigTag").GetComponent<DelegateController>();
    life = INITIAL_LIFE;
    isDead = false;
  }

  private void UpdateIfDead() {
    isDead = life <= 0;
  }

  IEnumerator Die() {
    isDead = true;
    GetComponent<Animator>().Play("Die");
    yield return new WaitForSeconds(3);
    gameObject.SetActive(false);
  }

  void Update() {
    UpdateIfDead();
    if (isDead) {
      StartCoroutine(Die());
    }
  }

  public bool IsDead() {
    return isDead;
  }

  private void DecreaseLife(string gameObjectName, int damageReceived) {
    if ((!isDead) && (gameObject.name == gameObjectName)) {
      life -= damageReceived;
    }
  }
}
