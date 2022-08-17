using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UIViews;
using DynamicBox.EventManagement;


public class MainMenuController : MonoBehaviour
{
  //We don't need view here ??? ask from teacher
  [SerializeField] private MainMenuView view;

  public void OnLanguageDropDownPressed(int languageIndex)
  {
    //Debug.Log(languageIndex);
    EventManager.Instance.Raise(new OnDropdownChangedEvent(languageIndex));
  }

}
