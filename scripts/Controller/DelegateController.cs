using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateController : MonoBehaviour {

  // Sistema de vida
  public delegate void DelegatePlayerDamage(int damageReceived);
  public delegate void DelegateEnemyDamage(string gameObjectName, int damageReceived);

  public event DelegatePlayerDamage getPlayerDamageEvent;
  public event DelegateEnemyDamage getEnemyDamageEvent;

  // Coleccionables
  public delegate void DelegateGetCollectible(int increase);

  public event DelegateGetCollectible getMoreLifeEvent;
  public event DelegateGetCollectible getMorePowerEvent;

  // Granada
  public delegate void DelegateGrenadeController();

  public event DelegateGrenadeController pickGrenadeEvent;
  public event DelegateGrenadeController destroyCaveEntry;


  public void ExecuteDamageToPlayer(int damageReceived) {
    if (getPlayerDamageEvent != null) {
      getPlayerDamageEvent(damageReceived);
    }
  }

  public void ExecuteDamageToEnemy(string gameObjectName, int damageReceived) {
    if (getEnemyDamageEvent != null) {
      getEnemyDamageEvent(gameObjectName, damageReceived);
    }
  }

  public void ExecuteLifeCollectible(int lifeIncrease) {
    if (getMoreLifeEvent != null) {
      getMoreLifeEvent(lifeIncrease);
    }
  }

  public void ExecutePowerCollectible(int powerIncrease) {
    if (getMorePowerEvent != null) {
      getMorePowerEvent(powerIncrease);
    }
  }

  public void PlayerPicksUpGrenade() {
    if (pickGrenadeEvent != null) {
      pickGrenadeEvent();
    }
  }

  public void GrenadeDestroysCaveEntry() {
    if (destroyCaveEntry != null) {
      destroyCaveEntry();
    }
  }
}
