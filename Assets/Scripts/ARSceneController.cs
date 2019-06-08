using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARSceneController : MonoBehaviour {

	private GameObject Subject;

	void Awake() {
		Subject = GameObject.FindGameObjectWithTag("Subject");
	}

	void Start() {
		print(Subject.GetComponent<ARSubjectController>().subject.ToString());
	}

    void Update() {
        
    }
}
