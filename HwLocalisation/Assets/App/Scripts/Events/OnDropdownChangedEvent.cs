using DynamicBox.EventManagement;


public class OnDropdownChangedEvent : GameEvent
{
  public int loginIndex;

  public OnDropdownChangedEvent(int _languageIndex)
  {
    loginIndex = _languageIndex; 
  }
}
