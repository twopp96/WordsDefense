using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnManager : MonoBehaviour
{
    IEnumerator saveCouroutine;
    public static SpawnManager instance;

    public int enemyCount;
    public TextMeshProUGUI countText;

    public float time;
    public TextMeshProUGUI timeText;

    public GameObject[] prefab;
    public int poolingSize = 30;

    public GameObject[] prefabBoss;

    public Transform[] pos;
    public int startPos = 10;

    public GameObject fastIconEffect;

    public int goToBoss;
    public int GoToBoss
    {
        get { return goToBoss; }
        set
        {
            goToBoss = value;
            if (goToBoss == 3)
            {
                StopCoroutine(saveCouroutine);
            }
        }
    }
    public bool isOnce;
    bool isFast;
    public bool IsFast
    {
        get { return isFast; }
        set
        {
            isFast = value;
            if (isFast)
            {
                Time.timeScale = 3f;
                fastIconEffect.gameObject.SetActive(true);
            }
            else if (isFast == false)
            {
                Time.timeScale = 1f;
                fastIconEffect.gameObject.SetActive(false);
            }
        }
    }
    public void FastToggle()
    {
        if (IsFast == true) IsFast = false;
        else if (IsFast == false) IsFast = true;
    }

    public void Awake()
    {
        if (instance == null)
            instance = this;
        else Destroy(gameObject);

        time = 90f;
        isOnce = false;

        poolingSize = 30;
        GoToBoss = 0;

        saveCouroutine = StartActive();
        StartCoroutine(saveCouroutine);
    }

    IEnumerator StartActive()
    {
        yield return new WaitForSeconds(5f);
        for (int i = 0; i < poolingSize; i++)
        {
            Instantiate(prefab[i], pos[startPos].transform.position, pos[startPos].transform.rotation);
            enemyCount++;
            if (enemyCount > 60) countText.color = Color.red;
            countText.text = enemyCount.ToString() + "/80";
            yield return new WaitForSeconds(3f);
        }
        Debug.Log("아직 true");
        isOnce = false;
        Debug.Log("false 전환");

        GoToBoss++;
        if (GoToBoss == 3)
        {
            isOnce = true;
            StopCoroutine(saveCouroutine);
            StartCoroutine(BossActive(GoToBoss));
        }
    }

    IEnumerator BossActive(int num)
    {
        Instantiate(prefabBoss[num / 3 - 1], pos[startPos].transform.position, pos[startPos].transform.rotation);
        yield return null;
    }

    private void Update()
    {
        if (time <= 0)
        {
            if (isOnce == false)
            {
                time = 90f;
                saveCouroutine = StartActive();
                StartCoroutine(saveCouroutine);
                isOnce = true;
            }
            else time = 0;
        }
        if (enemyCount > 80 || time == 0)
        {
            StopAllCoroutines();
            Debug.Log("GameOver");
            SceneManager.LoadScene(3);
        }
        time -= Time.deltaTime;
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }


}
