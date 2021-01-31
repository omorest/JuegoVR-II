using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateTerrain : MonoBehaviour {
  public GameObject terrain;

  IEnumerator Deactivate() {
    yield return new WaitForSeconds(2f);
    terrain.SetActive(false);
  }

  void OnCollisionEnter(Collision collision) {
    if (collision.gameObject.tag == "PlayerTag") {
      StartCoroutine(Deactivate());
    }
  }
}
