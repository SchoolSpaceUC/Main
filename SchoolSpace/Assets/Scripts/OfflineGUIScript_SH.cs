using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

    public class OfflineGUIScript_SH : MonoBehaviour
    {
        void Start()
        {
            Camera.main.enabled = true;
        }

        void OnGUI()
        {
            GUILayout.BeginArea(new Rect((Screen.width / 2) - 100, (Screen.height /2) - 65, 200, 130));

            GUILayout.Box("You are offline, please click \njoin game to open the lobby");
            GUILayout.Box("Hint: Use the WASD keys to \nmove & turn");

            if (GUILayout.Button("Join Game"))
            //load the scene (name of your lobby scene)
                SceneManager.LoadScene("SHGameLobby");
            GUILayout.EndArea();
        }
    }
