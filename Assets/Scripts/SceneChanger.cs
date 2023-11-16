using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void OpenMountainScene()
    {
        SceneManager.LoadScene("first_mountain_scene");
    }

    public void OpenWindmillScene()
    {
        SceneManager.LoadScene("second_windmill_scene");
    }
}
