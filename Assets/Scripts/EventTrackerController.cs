using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class EventTrackerController : MonoBehaviour, ITrackableEventHandler {
	
	private TrackableBehaviour trackableBehaviour;
	private static GameObject Subject;
	private UIController.Subjects subject;
	[NonSerialized]
	public int numero;
	[Serializable]
	public struct Prefabs {
		public UIController.Subjects subject;
		public GameObject prefab;
	}
	public Prefabs[] prefabs;

	void Awake() {
		if (!Subject) {
			Subject = GameObject.FindGameObjectWithTag("Subject");
		}
	}

	void Start() {
		trackableBehaviour = GetComponent<TrackableBehaviour>();
		if (trackableBehaviour) {
			trackableBehaviour.RegisterTrackableEventHandler(this);
		}

		subject = Subject.GetComponent<ARSubjectController>().subject;
		
	}

	void ITrackableEventHandler.OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus) {
		if (newStatus == TrackableBehaviour.Status.DETECTED || newStatus == TrackableBehaviour.Status.TRACKED || newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED) {
			Debug.Log("Target Detected");
		} else {
			Debug.Log("Targed lost");
		}
	}

}
