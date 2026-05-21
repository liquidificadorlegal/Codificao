using UnityEngine;

public class NPC : MonoBehaviour
{
    public string nome;
    public bool interagivel;
    public int idade;


    void Start()
    {
        //NPC kaquesilva = new NPC();
        //kaquesilva.nome = "kaquesilva";
        //kaquesilva.idade = 67;
        //kaquesilva.interagivel = true;

        //NPC jonaswarchiken = new NPC();
        //jonaswarchiken.nome = "jonaswarchiken";
        //jonaswarchiken.idade = 7;
        //jonaswarchiken.interagivel = false;

        //Debug.Log("eese é o meu nome: " + nome); 
    }

    public void Falar()
    {
        Debug.Log("oi, meu nome è: " + nome + "né!");


    }

}
