using System;

namespace WF_4_Puzzle15;

[Serializable]
public class Score : IComparable<Score>, IEquatable<Score>
{
    public string Name { get; set; }
    public uint Moves { get; set; }
    public TimeSpan Timer { get; set; }


    #region IComparable<Score> implementation

    public int CompareTo(Score other)
    {
        if (Moves < other.Moves) return -1;
        if (Moves > other.Moves) return 1;
        if (Timer < other.Timer) return -1;
        if (Timer > other.Timer) return 1;
        return 0;
    }

    #endregion

    #region IEquatable<Score> implementation

    public bool Equals(Score other)
    {
        if (other is null) return false;
        if (object.ReferenceEquals(this, other)) return true;
        if (GetType() != other.GetType()) return false;
        return
            string.Compare(Name, other.Name, StringComparison.CurrentCulture) == 0 &&
            Moves.Equals(other.Moves) &&
            Timer.Equals(other.Timer);
    }

    #endregion


    #region 

    public override bool Equals(object other)
    {
        if (other is null) return false;
        if (object.ReferenceEquals(this, other)) return true;
        if (GetType() != other.GetType()) return false;
        return Equals(other as Score);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Moves, Timer.TotalSeconds);
    }

    public static bool operator ==(Score left, Score right) =>
        ReferenceEquals(left, null) ? ReferenceEquals(right, null) : left.Equals(right);

    public static bool operator !=(Score left, Score right) =>
        !(left == right);

    #endregion


    #region 

    public static bool operator <(Score left, Score right) =>
        ReferenceEquals(left, null) ? !ReferenceEquals(right, null) : left.CompareTo(right) < 0;

    public static bool operator <=(Score left, Score right) =>
        ReferenceEquals(left, null) || left.CompareTo(right) <= 0;

    public static bool operator >(Score left, Score right) =>
        !ReferenceEquals(left, null) && left.CompareTo(right) > 0;

    public static bool operator >=(Score left, Score right) =>
        ReferenceEquals(left, null) ? ReferenceEquals(right, null) : left.CompareTo(right) >= 0;

    #endregion
}
