using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour {

	public enum Subjects {
		Geo_earth,
		Geo_mountain
	}
	
	private static List<string> sceneStack;
	private static GameObject Subject;

	public Subjects subject;

	void Awake() {
		if (!Subject) {
			Subject = GameObject.FindGameObjectWithTag("Subject");
		}
	}

	void Start() {
		
		if (sceneStack == null) {
			sceneStack = new List<string>();
		}
	}

	void Update() {
		if (Input.GetKey(KeyCode.Escape)) {
			BackToPreviousScene();
		}
	}

	public void GoToScene(string scene) {
		//TODO: check if name scene is empty
		sceneStack.Add(SceneManager.GetActiveScene().name);
		SceneManager.LoadScene(scene);
	}

	public void GoToARScene() {
		Subject.GetComponent<ARSubjectController>().subject = subject;
		GoToScene("ARScene");
	}

	public void BackToPreviousScene() {
		string previousScene = sceneStack[sceneStack.Count - 1];
		sceneStack.RemoveAt(sceneStack.Count - 1);
		SceneManager.LoadScene(previousScene);
	}
}
