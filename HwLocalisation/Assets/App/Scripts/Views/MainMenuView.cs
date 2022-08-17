using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace UIViews {
  public class MainMenuView : MonoBehaviour
  {
    [Header("Controller reference")]
    [SerializeField] private MainMenuController controller;

    public void OnLanguageDropDownPressed(int languageIndex)
    {
      controller.OnLanguageDropDownPressed(languageIndex);
      //Debug.Log(languageIndex);
    }
  }
}
