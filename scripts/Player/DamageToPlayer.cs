using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageToPlayer : MonoBehaviour {
  private DelegateController controller;

  private int dragonDamage;

  private void Awake() {
    controller = GameObject.FindWithTag("CameraRigTag").GetComponent<DelegateController>();
    dragonDamage = 1;
  }

  void OnCollisionEnter(Collision collision) {
    // if (collision.gameObject.name == "Troll") {
    //   controller.ExecuteDamageToPlayer(1);
    // }

    if (collision.gameObject.tag == "DragonTag") {
      controller.ExecuteDamageToPlayer(dragonDamage);
    }
  }

  void OnCollisionStay(Collision collision) {
    // if (collision.gameObject.name == "Troll") {
    //   controller.ExecuteDamageToPlayer(dragonDamage);
    // }

    if (collision.gameObject.tag == "DragonTag") {
      controller.ExecuteDamageToPlayer(dragonDamage);
    }
  }

  void OnCollisionExit(Collision collision) {
    // if (collision.gameObject.name == "Troll") {
    //   controller.ExecuteDamageToPlayer(dragonDamage);
    // }

    if (collision.gameObject.tag == "DragonTag") {
      controller.ExecuteDamageToPlayer(dragonDamage);
    }
  }
}
