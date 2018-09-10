using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChangeDirector : MonoBehaviour {
    public void SceneChangeToSecondScene()
    {
        SceneManager.LoadScene("SecondScene");
    }
    public void SceneChangeToStory1()
    {
        SceneManager.LoadScene("Story1");
    }
    public void SceneChangeToStory2()
    {
        SceneManager.LoadScene("Story2");
    }
    public void SceneChangeToStory3()
    {
        SceneManager.LoadScene("Story3");
    }
    public void SceneChangeToStory4()
    {
        SceneManager.LoadScene("Story4");
    }
    public void SceneChangeToStage1()
    {
        SceneManager.LoadScene("Stage1");
    }
    public void SceneChangeToStage2()
    {
        SceneManager.LoadScene("Stage2");
    }
    public void SceneChangeToSettingScene()
    {
        SceneManager.LoadScene("settingScene");
    }
}
