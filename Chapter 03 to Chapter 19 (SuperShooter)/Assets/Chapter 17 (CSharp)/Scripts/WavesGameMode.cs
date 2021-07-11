using UnityEngine;
using UnityEngine.SceneManagement;

public class WavesGameMode : MonoBehaviour
{
    [SerializeField] Life_Chapter17 playerLife;
    [SerializeField] Life_Chapter17 playerBaseLife;

    void Start()
    {
        playerLife.onDeath.AddListener(OnPlayerLifeChanged);
        playerBaseLife.onDeath.AddListener(OnPlayerBaseLifeChanged);
        EnemyManager.instance.onChanged.AddListener(CheckWinCondition);
        WavesManager.instance.onChanged.AddListener(CheckWinCondition);
    }
    
    void CheckWinCondition()
    {
        if (EnemyManager.instance.enemies.Count <= 0 && WavesManager.instance.waves.Count <= 0)
        {
            SceneManager.LoadScene("WinScreen");
        }
    }
    
    void OnPlayerLifeChanged()
    {
        if (playerLife.amount <= 0)
        {
            SceneManager.LoadScene("LoseScreen");
        }
    }
    
    void OnPlayerBaseLifeChanged()
    {
        if (playerBaseLife.amount <= 0)
        {
            SceneManager.LoadScene("LoseScreen");
        }
    }
}