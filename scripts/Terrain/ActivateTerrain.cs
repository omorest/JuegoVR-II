using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateTerrain : MonoBehaviour {
  public GameObject terrain;

  IEnumerator Activate() {
    yield return new WaitForSeconds(2f);
    terrain.SetActive(true);
  }

  void OnCollisionEnter(Collision collision) {
    if (collision.gameObject.tag == "PlayerTag") {
      StartCoroutine(Activate());
    }
  }
}
