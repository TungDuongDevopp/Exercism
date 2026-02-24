public struct Coord : IEquatable<Coord>{
    public Coord(ushort x, ushort y) => (X,Y) = (x,y);

    public ushort X { get; }
    public ushort Y { get; }
    public bool Equals(Coord other)
        => X == other.X && Y == other.Y;
    
    public override bool Equals(object obj)
        => obj is Coord other && Equals(other);

    public override int GetHashCode()
        => HashCode.Combine(X, Y);
}

public struct Plot : IEquatable<Plot>{
    public Plot(Coord a, Coord b, Coord c, Coord d){
        A = a;
        B = b;
        C = c;
        D = d;
    }

    public Coord A { get; }
    public Coord B { get; }
    public Coord C { get; }
    public Coord D { get; }

    public bool Equals(Plot other)
        => A.Equals(other.A)
        && B.Equals(other.B)
        && C.Equals(other.C)
        && D.Equals(other.D);

    public override bool Equals(object obj)
        => obj is Plot other && Equals(other);

    public override int GetHashCode()
        => HashCode.Combine(A, B, C, D);
   
}

public class ClaimsHandler{
    private readonly HashSet<Plot> _claims = new();
    private readonly List<Plot> _order = new();

    public void StakeClaim(Plot plot){
        if (_claims.Add(plot))
            _order.Add(plot);
    }

    public bool IsClaimStaked(Plot plot)
        => _claims.Contains(plot);

    public bool IsLastClaim(Plot plot)
        => _order.Count > 0 && _order[^1].Equals(plot);

    public Plot GetClaimWithLongestSide(){
        if (_claims.Count == 0)
            throw new InvalidOperationException("No claims available.");

        return _claims
            .OrderByDescending(LongestSide)
            .First();
    }

    private static double Distance(Coord p1, Coord p2){
        var dx = p1.X - p2.X;
        var dy = p1.Y - p2.Y;
        return Math.Sqrt(dx * dx + dy * dy);
    }

    private static double LongestSide(Plot plot){
        var ab = Distance(plot.A, plot.B);
        var ac = Distance(plot.A, plot.C);
        var bd = Distance(plot.B, plot.D);
        var cd = Distance(plot.C, plot.D);

        return Math.Max(Math.Max(ab, ac), Math.Max(bd, cd));
    }
}

