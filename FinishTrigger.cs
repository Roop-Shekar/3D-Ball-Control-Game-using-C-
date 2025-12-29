using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishTrigger : MonoBehaviour
{
    public GameObject winPanel;
    public bool isLastLevel = false;

    void Start()
    {
        // VERY IMPORTANT: reset time
        Time.timeScale = 1f;

        if (winPanel != null)
            winPanel.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        Debug.Log("FINISH HIT");

        if (isLastLevel)
        {
            if (winPanel != null)
                winPanel.SetActive(true);

            Time.timeScale = 0f;
        }
        else
        {
            Debug.Log("LOADING NEXT LEVEL");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}