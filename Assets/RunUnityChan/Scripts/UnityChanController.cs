using UnityEngine;
using System.Collections;

public class UnityChanController : MonoBehaviour {

	// Use this for initialization
	public void OnTapped () {
		this.GetComponent<Animator>().SetTrigger ("Jump");
	}

  public void OnCollidedWithObstacle()
  {
    this.GetComponent<Animator>().SetTrigger("Collision");
  }

	// Update is called once per frame
	public void OnCallChangeFace () {

	}
}
