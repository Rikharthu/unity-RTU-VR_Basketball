using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class BallCatcher : MonoBehaviour {

	public EventTrigger.TriggerEvent OnBallHitEvent;

	void OnTriggerEnter(Collider collider)
    {	
		// FindObjectOfType<GameController>().StartRound();
		BaseEventData eventData= new BaseEventData(EventSystem.current);
		eventData.selectedObject=this.gameObject;
		OnBallHitEvent.Invoke(eventData);
    }
}
