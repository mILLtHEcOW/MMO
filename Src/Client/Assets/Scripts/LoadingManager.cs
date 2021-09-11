using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class LoadingManager : MonoBehaviour
{
    public GameObject loadingScreen;
    public Slider silider_loading;
    public Text text_loading;

    public GameObject tipsScreen;
    public GameObject loginScreen;

    private void Start()
    {
        StartCoroutine(GameStart());
    }
    IEnumerator GameStart()
    {
        tipsScreen.SetActive(true);
        loadingScreen.SetActive(false);
        loginScreen.SetActive(false);
        yield return new WaitForSeconds(2f);
        tipsScreen.SetActive(false);
        loadingScreen.SetActive(true);

        StartCoroutine(LoadLevel());
        for(float i = 35S; i < 100;)
        {
            i += Random.Range(0.15f, 0.2f);
            silider_loading.value = i;
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
