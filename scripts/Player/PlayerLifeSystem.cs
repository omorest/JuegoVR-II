using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLifeSystem : MonoBehaviour {
  private DelegateController controller;

  private int LIFE_FACTOR = 10;
  private int INITIAL_LIFE = 500;
  private int MAX_LIFE = 1000;
  private int MAX_BULLET_DAMAGE = 100;
  private int INITIAL_BULLET_DAMAGE = 25;

  public int life;
  private bool isDead;
  private int bulletDamage;

  private void Awake() {
    controller = GameObject.FindWithTag("CameraRigTag").GetComponent<DelegateController>();
    life = INITIAL_LIFE;
    bulletDamage = INITIAL_BULLET_DAMAGE;
    isDead = false;
  }

  IEnumerator LoadGameOverScene() {
    yield return new WaitForSeconds(1f);
    string GAME_OVER_SCENE = "GameOver";
    SceneManager.LoadScene(GAME_OVER_SCENE);
  }

  void OnEnable() {
    controller.getPlayerDamageEvent += DecreaseLife;
    controller.getMoreLifeEvent += IncreaseLife;
    controller.getMorePowerEvent += IncreaseBulletDamage;
  }

  void OnDeseable() {
    controller.getPlayerDamageEvent -= DecreaseLife;
    controller.getMoreLifeEvent -= IncreaseLife;
    controller.getMorePowerEvent -= IncreaseBulletDamage;
  }

  private void UpdateIfDead() {
    isDead = life <= 0;
  }

  void Update() {
    UpdateIfDead();
    if (isDead) { 
      StartCoroutine(LoadGameOverScene());
    }
  }

  private void DecreaseLife(int damageReceived) {
    if (!isDead) {
      life -= damageReceived;
    }
  }

  private void IncreaseBulletDamage(int powerIncrease) {
    if (bulletDamage + powerIncrease <= MAX_BULLET_DAMAGE) {
      bulletDamage += powerIncrease;
    } else {
      bulletDamage = MAX_BULLET_DAMAGE;
    }
  }

  private void IncreaseLife(int lifeIncrease) {
    if (life + lifeIncrease <= MAX_LIFE) {
      life += lifeIncrease;
    
    } else {
      life = MAX_LIFE;
    }
  }

  public int GetLife() {
    return life / LIFE_FACTOR;
  }

  public int GetBulletDamage() {
    return bulletDamage;
  }
}
