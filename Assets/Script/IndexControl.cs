using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IndexControl : MonoBehaviour
{
    public static IndexControl Instance;

    public Canvas canvas;

    // Start is called before the first frame update
    void Start()
    {
        if (Instance == null)
            Instance = this;
        else Destroy(gameObject);

        DontDestroyOnLoad(gameObject);

        canvas = GetComponent<Canvas>();
    }

    public void ChageSort()
    {
        canvas.sortingOrder = 50;
    }

    public void ChageSortBack()
    {
        canvas.sortingOrder = -200;
        canvas.targetDisplay = 1;
    }

    public void ChangeOveray()
    {
        canvas.renderMode = RenderMode.WorldSpace;
    }

}


