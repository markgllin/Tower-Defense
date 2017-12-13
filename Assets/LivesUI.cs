using UnityEngine;
using UnityEngine.UI;

public class LivesUI : MonoBehaviour {

    public Text livesText;

	//if doing mobile, consider using coroutine to make more efficient
	// Update is called once per frame
	void Update () {
        livesText.text = PlayerStats.Lives + " LIVES";
	}
}
