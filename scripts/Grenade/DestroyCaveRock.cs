using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCaveRock : MonoBehaviour {
  private DelegateController controller;
  public GameObject cave;

  private void Awake() {
    controller = GameObject.FindWithTag("CameraRigTag").GetComponent<DelegateController>();
  }
  
  public void Destroy() {
    cave.SetActive(true);
    controller.GrenadeDestroysCaveEntry();
    Destroy(gameObject);
  }
}
