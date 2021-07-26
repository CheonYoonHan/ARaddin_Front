using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_load : MonoBehaviour
{
    [SerializeField] string sceneName;

    public void Load()
    {
        SceneManager.LoadScene(sceneName);
    }
}
