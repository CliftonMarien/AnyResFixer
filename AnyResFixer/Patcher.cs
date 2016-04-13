using System;
using UnityEngine;

namespace AnyResFixer
{
	[KSPAddon(KSPAddon.Startup.EveryScene, false)]
	public class Patcher : MonoBehaviour
	{

		void Start () {

			GameSettings.SCREEN_RESOLUTION_HEIGHT = 720;
			GameSettings.SCREEN_RESOLUTION_WIDTH = 1280;
			GameSettings.FULLSCREEN = false;
			GameSettings.SaveSettings ();
			Screen.SetResolution(1280, 720, false);

			Debug.Log ("AnyRes Patcher: Fixed screen resolution.");

			PopupDialog.SpawnPopupDialog(new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), "Screen resolution fixed.", "AnyRes screen resolution fixed.  Please uninstall this plugin.  (Located at GameData/AnyResFixer.dll)", "OK", false, HighLogic.UISkin);

		}

	}
}

