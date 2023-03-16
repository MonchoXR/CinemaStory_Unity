using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventOnTrigger : MonoBehaviour
{
  public UnityEvent OnEnter;

  private void OnTriggerEnter(Collider other) {
    OnEnter.Invoke();
    Debug.Log("trigger entered by: "+ other.gameObject.name);
  }
}
