using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompassController : MonoBehaviour {
  private Transform player;
  private Vector3 rotation;
  
  private void Start() {
    player = Camera.main.transform;
    rotation = new Vector3(0, 0, 0);
  }

  private void Update() {
    rotation.z = Camera.main.transform.eulerAngles.y;
    transform.localEulerAngles = rotation;
  }
}
