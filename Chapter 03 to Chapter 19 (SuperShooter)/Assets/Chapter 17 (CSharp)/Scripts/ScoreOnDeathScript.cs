using UnityEngine;

public class ScoreOnDeathScript : MonoBehaviour
{
    public int scoreToWin;

    void OnDestroy()
    {
        ScoreManagerScript.instance.score += scoreToWin;
    }
}
