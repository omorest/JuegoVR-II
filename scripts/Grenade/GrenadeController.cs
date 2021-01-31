using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeController : MonoBehaviour {
  private float DELAY = 5f;

  private float RADIO = 5f;
  private float FORCE = 200f;

  public float countdown;
  private bool hasExploded = false;

  private void Start() {
    countdown = DELAY;
  }

  private void Update() {
    countdown -= Time.deltaTime;

    if ((countdown <= 0) && (hasExploded == false)) {
      ExplodeGrenade();
      hasExploded = true;
    }
  }

  private void ExplodeGrenade() {
    Collider[] colliders = Physics.OverlapSphere(transform.position, RADIO);

    foreach (Collider nearbyObject in colliders) {
      Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();

      if (rb != null) {
        rb.AddExplosionForce(FORCE, transform.position, RADIO);
      }

      DestroyCaveRock caveRock = nearbyObject.GetComponent<DestroyCaveRock>();
      if (caveRock != null) {
        caveRock.Destroy();
      }
    }
    Destroy(gameObject);
  }
}
