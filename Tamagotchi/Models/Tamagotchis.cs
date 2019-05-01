using System.Collections.Generic;
using System;

namespace TamagotchiFarm.Models
{
  public class Tamagotchi
  {
    private string _name;
    private int _health;
    private int _food;
    private int _attention;
    private int _rest;
    private int _id;
    private static List<Tamagotchi> _instances = new List<Tamagotchi> {};

    public string Name {get=> _name; set=> _name = value;}
    public int Health {get=> _health; set=> _health = value;}
    public int Food {get=> _food; set=> _food = value;}
    public int Attention {get=> _attention; set=> _attention = value;}
    public int Rest {get=> _rest; set=> _rest = value;}

    public Tamagotchi (string name)
    {
      _name = name;
      _health = 100;
      _food = 100;
      _attention = 100;
      _rest = 100;
      _instances.Add(this);
      _id = _instances.Count;
    }

    public int GetId()
    {
      return _id;
    }

    public static Tamagotchi Find(int searchId)
    {
      for(int i = 0; i < _instances.Count; i++)
      {
        if(_instances[i].GetId() == searchId)
        {
          return _instances[i];
        }
      }
      return _instances[0];
    }
    public static List<Tamagotchi> GetAll()
    {
      return _instances;
    }
    public static void MoveTime()
    {
      foreach(Tamagotchi tamagotchi in _instances)
      {
        tamagotchi.Health = tamagotchi.Health - 10;
        tamagotchi.Food = tamagotchi.Food - 10;
        tamagotchi.Attention = tamagotchi.Attention - 10;
        tamagotchi.Rest = tamagotchi.Rest - 10;
      }
    }
    public static void Feed(int searchId)
    {
      for(int i = 0; i < _instances.Count; i++)
      {
        if(_instances[i].GetId() == searchId)
        {
          _instances[i].Food = _instances[i].Food + 5;
        }
      }
    }
    public static void Heal(int searchId)
    {
      for(int i = 0; i < _instances.Count; i++)
      {
        if(_instances[i].GetId() == searchId)
        {
          _instances[i].Health = _instances[i].Health + 5;
        }
        // if(_instances[i].Health < 21)
        // {
        //   _instances[i].ShowMessage(_instances[i].Name + " is about to die", "Warning");
        //   // MessageBox.Show( _instances[i].Name + " is about to die");
        // }
      }
    }
    public static void Love(int searchId)
    {
      for(int i = 0; i < _instances.Count; i++)
      {
        if(_instances[i].GetId() == searchId)
        {
          _instances[i].Attention = _instances[i].Attention + 5;
        }
      }
    }
    public static void Sleep(int searchId)
    {
      for(int i = 0; i < _instances.Count; i++)
      {
        if(_instances[i].GetId() == searchId)
        {
          _instances[i].Rest = _instances[i].Rest + 5;
        }
      }
    }

   //  private void ShowMessage(string Message, string Title)
   // {
   //     ScriptManager.RegisterStartupScript(Page, this.GetType(), "alert", string.Format("alert('{1}', '{0}');", Message, Title), true);
   // }
  }
}
