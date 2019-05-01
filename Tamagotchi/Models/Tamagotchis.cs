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
  }
}
