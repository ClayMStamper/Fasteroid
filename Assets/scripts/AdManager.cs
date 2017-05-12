using UnityEngine;
using UnityEngine.Advertisements;
using System.Collections;

public class AdManager : MonoBehaviour {

	public void ShowAd(){
		if (Advertisement.IsReady ()) {
			Advertisement.Show ("", new ShowOptions(){resultCallback = AdResults});
		}
	}
	public void AdResults(ShowResult result){
		switch (result) {
		case ShowResult.Finished:
			Debug.Log ("add finished");
			break;
		case ShowResult.Skipped:
			Debug.Log ("add skpped");
			break;
		case ShowResult.Failed:
			Debug.Log ("failed to launch ad");
			break;
		}
	}
}
