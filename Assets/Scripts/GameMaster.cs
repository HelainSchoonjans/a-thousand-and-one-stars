using UnityEngine;
using TMPro;

public class GameMaster : MonoBehaviour
{
    public TextMeshProUGUI reputationScoreText;
    public TextMeshProUGUI experienceScoreText;
    public TextMeshProUGUI wealthScoreText;
    public Player currentPlayer;

    public void UpdatePlayerScores()
    {
        if(currentPlayer)
        {
            reputationScoreText.text = currentPlayer.reputation.ToString();
            experienceScoreText.text = currentPlayer.experience.ToString();
            wealthScoreText.text = currentPlayer.wealth.ToString();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        UpdatePlayerScores();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerWins();
        }
    }

    void PlayerWins()
    {
        // the game ends, a win message box appears.
    }
}
