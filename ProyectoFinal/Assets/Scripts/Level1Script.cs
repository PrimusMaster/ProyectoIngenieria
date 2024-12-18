using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Script : MonoBehaviour
{
    public int Puntaje { get; private set; }

    public void Calificar(int Score)
    {
        Puntaje += Score;
    }

    public int Resp()
    {
        return Puntaje;
    }
}
