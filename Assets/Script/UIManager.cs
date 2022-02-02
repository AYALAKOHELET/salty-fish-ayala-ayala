using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Text PlayerHPText;

    [SerializeField]
    private Doll Doll;

    // Start is called before the first frame update
    void Start()
    {
        Doll.isPlayerCaught += ChangeTheNumberHPText;
    }

    private void ChangeTheNumberHPText(bool isCaught, int PlayerHp)
    {
        if (isCaught == true )
        {
            Debug.Log("PlayerHP:" + PlayerHp);
            PlayerHPText.text = $"PlayerHP:{PlayerHp.ToString()}";
            isCaught = false;
        }
    }

}
