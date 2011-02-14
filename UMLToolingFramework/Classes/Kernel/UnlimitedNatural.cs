namespace TSF.UmlToolingFramework.UML.Classes.Kernel {
  public class UnlimitedNatural {
    private int _value;
    public int? integerValue { 
      get { if(this._value >= 0) { return _value; } else { return null; } }
      set { }
    }
    
    public bool isUnlimited {
      get { return this._value < 0; }
      set { if(value) { this._value = -1; } }
    }
  }
}
