using UnityEngine;
using UnityEngine.UI;

public class ConceptNames : Singleton<ConceptNames>
{
    public enum EConceptNames
    {
        Cafe,
        Museum,
        NightClub,
        Home,
        Concert,
        Restaurant,
        Garden,
        Travel,
        GYM,
        Street
    }

    [SerializeField] private Text _content;

    public void SetConceptNames(int index)
    {
        EConceptNames desiredItem = (EConceptNames)index;

        Debug.Log("ENUM = " + desiredItem);

        switch (desiredItem)
        {
            case EConceptNames.Cafe:
                _content.text = "Cafe";
                break;
            case EConceptNames.Museum:
                _content.text = "Museum";
                break;
            case EConceptNames.NightClub:
                _content.text = "NightClub";
                break;
            case EConceptNames.Home:
                _content.text = "Home";
                break;
            case EConceptNames.Concert:
                _content.text = "Concert";
                break;
            case EConceptNames.Restaurant:
                _content.text = "Restaurant";
                break;
            case EConceptNames.Garden:
                _content.text = "Garden";
                break;
            case EConceptNames.Travel:
                _content.text = "Travel";
                break;
            case EConceptNames.GYM:
                _content.text = "GYM";
                break;
            case EConceptNames.Street:
                _content.text = "Street";
                break;
            default:
                _content.text = "No Concept";
                break;

        }
    }
}

