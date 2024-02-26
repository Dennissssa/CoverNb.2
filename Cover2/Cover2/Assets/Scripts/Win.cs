using UnityEngine;
using UnityEngine.SceneManagement;

public class Point : MonoBehaviour
{
    private bool isPointCovered;
    private float overlapTime;

    [SerializeField]
    public string nextLevelName; // 下一关卡的名称

    void Update()
    {
        if (isPointCovered)
        {
            overlapTime += Time.deltaTime;

            if (overlapTime >= 5f)
            { 
                LoadNextLevel();
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isPointCovered = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isPointCovered = false;
            overlapTime = 0f;
        }
    }

    void LoadNextLevel()
    {
        SceneManager.LoadScene(nextLevelName);
    }
}