using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class IntroText : MonoBehaviour {

	public Text introText;
	public Text trapText;
	public Text ideaText;
	public Text whatsThisText;
	public Text exploreText;

	public GameObject funnySkull;

	void sayIntro(){
		//funnySkull.SetActive(false);
		trapText.text = "";
		ideaText.text = "";
		whatsThisText.text = "";
		exploreText.text = "";
		introText.text = "WE HAVE FINALLY ENTERED THE CAVE! LET'S FIND THE TREASURE!";
	}

	void sayTrapText(){
		introText.text = "";
		//ideaText.text = "";
		trapText.text = "NO GOOD. WE NEED TO FIND SOME WAY TO GET THROUGH!";
	}

	void sayIdeaText(){
		trapText.text = "";
		ideaText.text = "MAYBE WE CAN FIND SOMETHING THIS WAY?";
	}

	void sayWhatsThis(){
		ideaText.text = "";
		whatsThisText.text = "IT SEEMS SOMETHING IS DOWN HERE!";
	}

	void sayExploreText(){
		whatsThisText.text = "";
		exploreText.text = "CAN YOU FIND THE HIDDEN TRIGGER?";
	}

	void explore(){
		funnySkull.SetActive(true);
		exploreText.text = "";
	}
}
