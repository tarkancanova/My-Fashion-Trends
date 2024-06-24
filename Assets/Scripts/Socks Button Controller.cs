using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class SocksButtonController : MonoBehaviour
{
    [SerializeField] private ModelSocksController _modelSocksController;
    public string category;
    [SerializeField] private GameObject _progressionBar;
    public int shoesIndex;
    [SerializeField] private GameObject _levelBar;
    [SerializeField] private LevelData _levelData;
    private Button _button;
    [SerializeField] private BackgroundManager _backgroundManager;
    [SerializeField] private ButtonListener _buttonListener;
    [SerializeField] private GameObject _shineParticle;
    private Coroutine _particleEffect;


    //This script assigns buttons for socks category.

    private void OnEnable()
    {
        _button = GetComponent<Button>();
        if (_button != null)
        {
            _button.onClick.AddListener(OnClickButton);
        }
    }

    private void OnDisable()
    {
        if (_button != null)
        {
            _button.onClick.RemoveListener(OnClickButton);
        }
    }

    private void OnClickButton()
    {
        ParticleEffect();
        _modelSocksController.ChangeSocksModel(shoesIndex);
        CompletionBar completionBar = _progressionBar.GetComponent<CompletionBar>();
        //LevelProgressionBar levelProgressionBar = _levelBar.GetComponent<LevelProgressionBar>();

        completionBar.AssignClickedCategory(category); //Assigns a category for the p. bar's progression block.
        completionBar.FillTheBar(); //P. bar progression.
        //levelProgressionBar.LevelUp(); //Level bar progression.
        completionBar.ActivateContinueButton();
        //_button.onClick.RemoveListener(_buttonListener.LevelProgressionOnClick); //Blocks the level bar progression on clicked dress.
    }
    private void ParticleEffect()
    {
        _shineParticle.GetComponent<ParticleSystem>().Stop();
        _shineParticle.GetComponent<ParticleSystem>().Clear();
        _shineParticle.GetComponent<ParticleSystem>().Play();
    }




}
