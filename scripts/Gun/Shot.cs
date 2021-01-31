using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour {
  public GameObject bullet;
  public Transform spawnPoint;

  private float SHOT_FORCE = 5000;
  private float SHOT_RATE = 0.5f;
  private float SHOT_RATE_TIME = 0;

  private AudioSource audioSource;
  public AudioClip soundShot;

  private void Start() {
    audioSource = GetComponent<AudioSource> ();
  }

  private void Update() {
    if (Input.GetButtonDown("Fire1")) { 
      if (Time.time > SHOT_RATE_TIME) {
        GameObject newBullet;

        newBullet = Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
        newBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * SHOT_FORCE);

        SHOT_RATE_TIME = Time.time + SHOT_RATE;
        
        audioSource.clip = soundShot;
        audioSource.Play();

        Destroy(newBullet, 1.5f);    
      }
    }
  }
}
