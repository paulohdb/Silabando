using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{

    private GameManager gameManager;

    void Clicou()
    {
        gameManager.Verifica(this.gameObject);
    }
    
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(Clicou);
        gameManager = FindObjectOfType<GameManager>();
    }
}
