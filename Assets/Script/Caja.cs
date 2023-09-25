using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caja : MonoBehaviour
{
    public delegate void ScoreEvento();
    public static ScoreEvento scoreEvento;

    public void OnJointBreak()
    {
        scoreEvento?.Invoke();
    }
}
