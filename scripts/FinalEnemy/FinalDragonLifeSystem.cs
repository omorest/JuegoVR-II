using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalDragonLifeSystem : MonoBehaviour {
  private DelegateController controller;
  public GameObject star;

  private int INITIAL_LIFE = 1500;
  private int LIFE_FACTOR = 100;

  public int life;
  private bool isDead;

  private void OnEnable() {
    controller.getEnemyDamageEvent += DecreaseLife;
  }

  private void OnDeseable() {
    controller.getEnemyDamageEvent -= DecreaseLife;
  }

  private void Awake() {
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
    star.SetActive(true);
    gameObject.SetActive(false);
  }

  private void Update() {
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

  public int getVida() {
      return life / LIFE_FACTOR;
  }
}
