using UnityEngine;
using UnityEngine.UI;

public class ChangeButtonText : MonoBehaviour {

  // Button we are going to change the text of.
  public Button button;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

  public void ChangeText() {
    if(button) {
      // Gets the Text child object of the button so that we can set its text.
      Text buttonText = button.GetComponentInChildren<Text>();
      buttonText.text = "Pizza";
    }
  }
}
