using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChangeLookAtTarget : MonoBehaviour {

	public GameObject target; // the target that the camera should look at
	private static TextMesh name;

	void Start() {
		if (target == null) 
		{
			target = this.gameObject;
			Debug.Log ("ChangeLookAtTarget target not specified. Defaulting to parent GameObject");
		}
	}

	// Called when MouseDown on this gameObject
	void OnMouseDown () {
		// change the target of the LookAtTarget script to be this gameobject.
		LookAtTarget.target = target;
		Camera.main.fieldOfView = 60*target.transform.localScale.x;
		TextMesh text_3d = GameObject.Find("Target_Text").GetComponent<TextMesh>();
		Debug.Log("Getting text3d=>" +text_3d);
		Debug.Log("Getting targetName =>" +target.name);
		text_3d.text = target.name;
	}
}
