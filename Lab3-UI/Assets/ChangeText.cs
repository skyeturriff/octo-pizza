using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour {

  public Text textToChange;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

  public void ChangeTextWithSliderValue(Slider slider) {
    if(slider && textToChange) {
      // Sets the text based on the current value of the slider.
      textToChange.text = "The slider is currently at: " + slider.value; 
    }
  }
}
