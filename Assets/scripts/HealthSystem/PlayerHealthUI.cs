using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthUI : MonoBehaviour
{
    [SerializeField] private Text _text;

    public void updateUI(float Lives)
    {
        _text.text = "Player Lives: " + Lives;
    }
}
