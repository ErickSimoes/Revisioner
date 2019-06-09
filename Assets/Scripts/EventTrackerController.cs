using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTrackerController : MonoBehaviour {
	
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
		subject = Subject.GetComponent<ARSubjectController>().subject;

		foreach (Prefabs prefab in prefabs) {
			if (prefab.subject == subject) {
				Instantiate(prefab.prefab, this.gameObject.transform);
			}
		}
		
	}

}
