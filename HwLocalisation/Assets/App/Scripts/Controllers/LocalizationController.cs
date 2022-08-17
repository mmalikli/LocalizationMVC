using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DynamicBox.EventManagement;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

public class LocalizationController : MonoBehaviour
{
  //private int languageIndex;

  private void OnEnable() 
  {
    EventManager.Instance.AddListener<OnDropdownChangedEvent>(OnDropdownChangedEventHandler);
  }
  private void OnDisable()
  {
    EventManager.Instance.RemoveListener<OnDropdownChangedEvent>(OnDropdownChangedEventHandler);
  }

  private void OnDropdownChangedEventHandler(OnDropdownChangedEvent eventDetails)
  {
    //Debug.Log(eventDetails.loginIndex);

    Locale selectedLocale = LocalizationSettings.AvailableLocales.Locales[eventDetails.loginIndex];
    LocalizationSettings.Instance.SetSelectedLocale(selectedLocale);
  }
}
