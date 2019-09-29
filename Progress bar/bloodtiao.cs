using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Globe
{
    public static string nextSceneName;
}

public class bloodtiao : MonoBehaviour
{
    public Text loadingText;
    public Image progressBar;
    private int curProgressValue = 0;
    private AsyncOperation operation;
    public static int a = 0;
    public static int clicks = 0;
    // Use this for initialization
    void onClick()
    {
        clicks += 1;
        Debug.Log("click!" + clicks);
        a = 1;
    }
    void Start()
    {       //获取按钮游戏对象
        GameObject btnObj = GameObject.Find("Canvas/Button");
        //获取按钮脚本组件
        Button btn = (Button)btnObj.GetComponent<Button>();
        //添加点击侦听
        btn.onClick.AddListener(onClick);

        if (SceneManager.GetActiveScene().name == "Loading")
        {
            //启动协程
            StartCoroutine(AsyncLoading());
        }
    }

    IEnumerator AsyncLoading()
    {
        operation = SceneManager.LoadSceneAsync(Globe.nextSceneName);
        //阻止当加载完成自动切换
        operation.allowSceneActivation = false;

        yield return operation;
    }

    // Update is called once per frame
    void Update()
    {

        int progressValue = 100;

        if (curProgressValue < progressValue && a == 1)
        {
            curProgressValue += 20;
            a = 0;
        }

        loadingText.text = curProgressValue + "%";//实时更新进度百分比的文本显示  

        progressBar.fillAmount = curProgressValue / 100f;//实时更新滑动进度图片的fillAmount值  

        if (curProgressValue == 100)
        {
            operation.allowSceneActivation = true;//启用自动加载场景  
            loadingText.text = "OK";//文本显示完成OK  

        }
    }
}