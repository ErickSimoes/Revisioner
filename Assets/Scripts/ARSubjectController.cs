using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARSubjectController : MonoBehaviour {

	public UIController.Subjects subject;

	void Awake() {
		DontDestroyOnLoad(this.gameObject);
	}
	
}
