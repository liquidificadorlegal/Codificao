using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<Inimigo> inimigolist = new();


    private void Start()
    {
        for (int i = 0; i < inimigolist.Count; i++)
        {
            inimigolist[i].Atacar();
        
        }
    }
}
