using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hp : MonoBehaviour
{

   [SerializeField] private int vida;
    [SerializeField] private GameObject HpBar;
 
    public void MostrarVida()
    {
        HpBar.SetActive(true);
    }



    private void OnEnable()
    {
        EvilDoor.ActivarHp += MostrarVida;
    }
    private void OnDisable()
    {
        EvilDoor.ActivarHp -= MostrarVida;

    }
}
