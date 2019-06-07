using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour {

	[SerializeField]
	public static List<string> sceneStack;

	void Start() {
		if (sceneStack == null) {
			sceneStack = new List<string>();
		}
	}


	public void GoToScene(string scene) {
		sceneStack.Add(SceneManager.GetActiveScene().name);
		SceneManager.LoadScene(scene);
	}

	public void BackToPreviousScene() {
		string previousScene = sceneStack[sceneStack.Count - 1];
		sceneStack.RemoveAt(sceneStack.Count - 1);
		SceneManager.LoadScene(previousScene);
	}
}
