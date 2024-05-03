using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GestionTexte : MonoBehaviour
{
    [SerializeField] private TMP_Text _txtNomJeu = default(TMP_Text);
    [SerializeField] private Image _imageFond;
    [SerializeField] private Color _couleurSurvol;

    private Color _couleurInitialeTexte;
    private Color _couleurInitialeImage;

    private void Start()
    {
        _couleurInitialeTexte = _txtNomJeu.color;
        _couleurInitialeImage = _imageFond.color;
    }

    public void ChangerTexteEnter()
    {
        _txtNomJeu.color= _couleurSurvol;
        _imageFond.color = _couleurSurvol;
    }

    public void ChangerTexteExit()
    {
        _txtNomJeu.color = _couleurInitialeTexte;
        _imageFond.color= _couleurInitialeImage;
    }
}
