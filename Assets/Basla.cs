using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Basla : MonoBehaviour
{
    public Button playervsai;
    public Button aivsai;

    void Start()
    {
        playervsai.onClick.AddListener(BaslatPlayervsAI);
        aivsai.onClick.AddListener(BaslatAIvsAı);
    }

    public void BaslatPlayervsAI()
    {
        SceneManager.LoadScene("playervsai");
    }

    public void BaslatAIvsAı()
    {
        SceneManager.LoadScene("aivsai");
    }
}