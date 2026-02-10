public class FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }
 
    public override bool Equals(object obj)
    {
        if (obj is not FacialFeatures other) return false;
        return EyeColor == other.EyeColor && PhiltrumWidth == other.PhiltrumWidth;
    }
    public override int GetHashCode()
    => HashCode.Combine(EyeColor, PhiltrumWidth);
    
}

public class Identity
{
    public string Email { get; }
    public FacialFeatures FacialFeatures { get; }

    public Identity(string email, FacialFeatures facialFeatures)
    {
        Email = email;
        FacialFeatures = facialFeatures;
    }
     public override bool Equals(object obj){
         if(obj is not Identity other) return false;
         return Email == other.Email && FacialFeatures.Equals(other.FacialFeatures);
     } 
    public override int GetHashCode() 
        => HashCode.Combine(Email,FacialFeatures);
}

public class Authenticator
{     private readonly HashSet<Identity> _registered = [];
    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB)
    => faceA.Equals(faceB);

    public bool IsAdmin(Identity identity)
    => identity.Equals(
        new Identity(
            "admin@exerc.ism",
            new FacialFeatures("green", 0.9m)
        )
    );

    public bool Register(Identity identity)
      => _registered.Add(identity);

    public bool IsRegistered(Identity identity)
    => _registered.Contains(identity);

    public static bool AreSameObject(Identity identityA, Identity identityB)
    =>  ReferenceEquals(identityA, identityB);
}
