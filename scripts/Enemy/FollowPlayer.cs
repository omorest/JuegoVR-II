using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

  private float MAX_DISTANCE_WITH_PLAYER = 8f;
  private float FORCE = 200000f;

  private GameObject player;
  private Rigidbody rb;

  private void Start() {
    rb = GetComponent<Rigidbody>();
    player = GameObject.FindWithTag("PlayerTag");
  }

  private bool CheckIfAlive() {
    DragonLifeSystem dragonLifeSystem = GetComponent<DragonLifeSystem>();
    return !dragonLifeSystem.IsDead();
  }

  void Update() {  
    float currentDistance = Vector3.Distance(transform.position, player.transform.position);
    
    if ((CheckIfAlive()) && (currentDistance <= MAX_DISTANCE_WITH_PLAYER)) {
      transform.LookAt(player.transform);
      rb.AddForce(transform.forward * FORCE);
      GetComponent<Animator>().Play("Run");
    }
  }
}