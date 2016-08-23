namespace TSF.UmlToolingFramework.UML.Classes.Kernel {
  public class UnlimitedNatural {
    private int _value;
    
    public int? integerValue {
      get { if(this._value >= 0) { return _value; } else { return null; } }
      set { if (value.HasValue) this._value = value.Value; }
    }
    
    public bool isUnlimited {
      get { return this._value < 0; }
      set { if(value) { this._value = -1; } }
    }
  }
}
