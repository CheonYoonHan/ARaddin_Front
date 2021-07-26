using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class take_photo : MonoBehaviour
{
    [SerializeField] GameObject blink;

    public GameObject shotbtn;
    public static int max = shot_num.shot_number;
    int count = 0;

    [SerializeField] string sceneName;

    void Update()
    {
        shotbtn.SetActive(true);
    }

    public void Load()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void TakeAShot()
    {
        StartCoroutine("CaptureIt");
        shotbtn.SetActive(false);
        Invoke("Update", 1f);
        count += 1;
        if (count == max)
        {
            Load();
        }
    }

    IEnumerator CaptureIt()
    {
        string timeStamp = System.DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss");
        string fileName = "Screenshot" + timeStamp + ".png";
        string pathToSave = fileName;
        ScreenCapture.CaptureScreenshot(pathToSave);
        yield return new WaitForEndOfFrame();
        Instantiate(blink, new Vector2(0f, 0f), Quaternion.identity);
    }
}
