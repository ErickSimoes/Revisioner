using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class EventTrackerController : MonoBehaviour, ITrackableEventHandler {
	
	private TrackableBehaviour trackableBehaviour;

	void Start() {
		trackableBehaviour = GetComponent<TrackableBehaviour>();
		if (trackableBehaviour) {
			trackableBehaviour.RegisterTrackableEventHandler(this);
		}
	}

	void ITrackableEventHandler.OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus) {
		if (newStatus == TrackableBehaviour.Status.DETECTED || newStatus == TrackableBehaviour.Status.TRACKED || newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED) {
			Debug.Log("Target Detected");
		} else {
			Debug.Log("Targed lost");
		}
	}

}
