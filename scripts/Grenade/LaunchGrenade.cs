using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchGrenade : MonoBehaviour {
  private DelegateController controlador;

  public float LAUNCH_FORCE = 200f;

  public GameObject grenadeObject;
  public GameObject gunObjectToDisable;
  public GameObject grenadeToActivate;
  private GameObject gunScriptToDisable;

  private int hasGrenade = 0;
  private bool doorIsDestroyed = false;
  private bool activatedGrenade = false;

  void Awake () {
    controlador = GameObject.FindWithTag("CameraRigTag").GetComponent<DelegateController>();
  }

  void OnEnable() {
    controlador.pickGrenadeEvent += PickGrenade;
    controlador.destroyCaveEntry += DestroyEntry;
  }

  void OnDeseable() {
    controlador.pickGrenadeEvent -= PickGrenade;
    controlador.destroyCaveEntry -= DestroyEntry;
  }

  void PickGrenade() {
    hasGrenade += 1;
  }

  void DestroyEntry() {
    doorIsDestroyed = true;
    hasGrenade = 0;
  }

  void Update() {
    if (hasGrenade > 0) {
      if (doorIsDestroyed == false) {
        gunObjectToDisable.SetActive(false);
        grenadeToActivate.SetActive(true);

        activatedGrenade = true;
        gunScriptToDisable = GameObject.FindWithTag("PlayerTag");
        gunScriptToDisable.GetComponent<Shot>().enabled = false;
        
        if (Input.GetButtonDown("Fire1")) {
          Launch();
        }
      }
    
    } else {
      if (activatedGrenade == true) {
        gunObjectToDisable.SetActive(true);
        grenadeToActivate.SetActive(false);
        
        gunScriptToDisable = GameObject.FindWithTag("PlayerTag");
        gunScriptToDisable.GetComponent<Shot>().enabled = true;
      }
    }
  }

  void Launch() {
    GameObject grenade = Instantiate(grenadeObject, transform.position, transform.rotation);

    Rigidbody rb = grenade.GetComponent<Rigidbody>();
    rb.AddForce(transform.forward * LAUNCH_FORCE, ForceMode.VelocityChange);

    grenade.GetComponent<GrenadeController>().enabled = true;
    hasGrenade -= 1;
  }
}
