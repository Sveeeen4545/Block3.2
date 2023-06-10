using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyVision : MonoBehaviour
{
    public Scene scene;
    string sceneName;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            scene = SceneManager.GetActiveScene();
            sceneName = scene.name;
            Debug.Log(sceneName);
            switch (sceneName)
            {
                case "ThorstenFromMall":
                    SceneManager.LoadScene("RestartSceneFromMall");
                    break;

                case "ThorstenFromLibrary":
                    SceneManager.LoadScene("RestartSceneFromLibrary");
                    break;
            }
        }
    }
}