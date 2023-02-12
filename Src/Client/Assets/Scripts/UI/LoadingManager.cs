using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class LoadingManager : MonoBehaviour
{
    public GameObject loadingScreen;
    public Slider loadingSlider;
    public Text loadingText;

    public GameObject tipsScreen;
    public GameObject loginScreen;

    private void Start()
    {
        StartCoroutine(GameStart());
    }
    IEnumerator GameStart()
    {
        log4net.Config.XmlConfigurator.ConfigureAndWatch(new System.IO.FileInfo("log4net"));
        UnityLogger.Init();
        Common.Log.Init("Unity");
        Common.Log.Init("Game Started");

        yield return DataManager.Instance.LoadData();

        tipsScreen.SetActive(true);
        loadingScreen.SetActive(false);
        loginScreen.SetActive(false);

        //yield return new WaitForSeconds(3f);//看三秒警告 方便测试已注销

        tipsScreen.SetActive(false);
        loadingScreen.SetActive(true);

        StartCoroutine(LoadLevel());
        for (float i = 1; i < 100;)
        {
            i += Random.Range(0.7f, 0.9f);
            loadingSlider.value = i;
            loadingText.text = ((int)i) + "%";
            yield return new WaitForEndOfFrame();
        }

        loginScreen.SetActive(true);
        loadingScreen.SetActive(false);

    }

    IEnumerator LoadLevel()
    {
        yield return 0;
    }
}
