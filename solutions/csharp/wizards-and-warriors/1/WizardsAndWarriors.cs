 abstract class Character
 {
     protected string _characterType;
     protected Character(string characterType) => _characterType = characterType;

     public abstract int DamagePoints(Character target);

     public virtual bool Vulnerable() => false;
     

     public override string ToString() => $"Character is a {_characterType}";
     
 }

 class Warrior : Character
 {
     public Warrior() : base("Warrior") { }
     public override int DamagePoints(Character target)=>target.Vulnerable() ? 10 : 6 ;
     
 }

 class Wizard : Character
 {
     private bool _prepared=false;
     public Wizard() : base("Wizard") { }
     public override int DamagePoints(Character target) => Vulnerable() ? 3 : 12;
    
     public override bool Vulnerable() => !_prepared;

     public void PrepareSpell()=>_prepared=true;
     
 }