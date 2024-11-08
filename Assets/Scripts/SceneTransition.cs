using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public int sceneBuildIndex;

    private void OnTriggerEnter2D(Collider2D other) {
        print("Trigger Entered");

        if(other.tag == "Player") {
            print("Scene switching to " + sceneBuildIndex);
            SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
        }
    }
}
