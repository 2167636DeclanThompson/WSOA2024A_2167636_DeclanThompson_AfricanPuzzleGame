using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public ScoreScript scoreScript;

    public void PlayerScored(int playerID)
    {
        scoreScript.PlayerScored(playerID);
    }
}
