using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenSquare : MonoBehaviour
{
    /// <summary>変えたいシーンの名前</summary>
    [SerializeField] string _changeScene;

    public void LoadScenes()
    {
        SceneManager.LoadScene(_changeScene);
    }
}
