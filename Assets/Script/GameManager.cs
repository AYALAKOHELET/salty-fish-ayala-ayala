using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int playerHp = 4;

    [SerializeField] private Text PlayerHPText;

    [SerializeField] private Doll Doll;

    public int PlayerHp
    {
        get { return playerHp; }
        set
        {
            playerHp = value;

            if (playerHp == 0)
            {
                SceneManager.LoadScene(1);

            }
        }
    }

    void Start()
    {
        Doll.isPlayerCaught += ChangeTheNumberHPText;
    }

    private void ChangeTheNumberHPText(bool isCaught, int PlayerHp)
    {
        if (isCaught == true)
        {
            Debug.Log("PlayerHP:" + PlayerHp);
            PlayerHPText.text = $"PlayerHP:{PlayerHp.ToString()}";
            isCaught = false;
        }
    }
}
