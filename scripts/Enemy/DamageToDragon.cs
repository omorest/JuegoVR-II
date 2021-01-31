using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageToDragon : MonoBehaviour {
  private DelegateController controller;
  private PlayerLifeSystem playerLifeSystem;
  
  private int bulletDamage;
  private int playerDamage;

  private void Awake() {
    playerLifeSystem = GameObject.FindWithTag("PlayerTag").GetComponent<PlayerLifeSystem>();
    controller = GameObject.FindWithTag("CameraRigTag").GetComponent<DelegateController>();
    playerDamage = 1;
  }

  void OnCollisionEnter(Collision collision) {
    if (collision.gameObject.tag == "BulletTag") {
      bulletDamage = playerLifeSystem.GetBulletDamage();
      controller.ExecuteDamageToEnemy(gameObject.name, bulletDamage);
    }

    if (collision.gameObject.tag == "PlayerTag") {
      controller.ExecuteDamageToEnemy(gameObject.name, playerDamage);
    }
  }

  void OnCollisionStay(Collision collision) {
    if (collision.gameObject.tag == "PlayerTag") {
      controller.ExecuteDamageToEnemy(gameObject.name, playerDamage);
    }
  }

  void OnCollisionExit(Collision collision) {
    if (collision.gameObject.tag == "PlayerTag") {
      controller.ExecuteDamageToEnemy(gameObject.name, playerDamage);
    }
  }
}
