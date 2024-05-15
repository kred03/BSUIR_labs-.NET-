public class CharSet
{
    private char[] _chars;

    public CharSet(char[] chars)
    {
        if (chars.Distinct().Count() != chars.Length)
            throw new ArgumentException("Множество символов не должно содержать повторяющихся символов.");
        _chars = chars;
    }

    public char this[int index]
    {
        get { return _chars[index]; }
        set
        {
            if (_chars.Contains(value))
                throw new ArgumentException("Этот символ уже присутствует в множестве.");
            _chars[index] = value;
        }
    }

    public override string ToString()
    {
        return new string(_chars);
    }

    public static CharSet operator +(CharSet a, CharSet b)
    {
        return new CharSet(a._chars.Union(b._chars).ToArray());
    }

    public static CharSet operator -(CharSet a, CharSet b)
    {
        return new CharSet(a._chars.Except(b._chars).ToArray());
    }

    public static CharSet operator *(CharSet a, CharSet b)
    {
        return new CharSet(a._chars.Intersect(b._chars).ToArray());
    }

    public static bool operator ==(CharSet a, CharSet b)
    {
        return a._chars.SequenceEqual(b._chars);
    }

    public static bool operator !=(CharSet a, CharSet b)
    {
        return !(a == b);
    }

    public static bool operator true(CharSet a)
    {
        return a._chars.Length > 0;
    }

    public static bool operator false(CharSet a)
    {
        return a._chars.Length == 0;
    }

    public static implicit operator string(CharSet a)
    {
        return a.ToString();
    }

    public static explicit operator CharSet(string s)
    {
        return new CharSet(s.ToCharArray());
    }

    public static CharSet operator ++(CharSet a)
    {
        return new CharSet(a._chars.Concat(new char[] { '1' }).ToArray());
    }

    public static CharSet operator --(CharSet a)
    {
        return new CharSet(a._chars.Take(a._chars.Length - 1).ToArray());
    }

    public override bool Equals(object obj)
    {
        if (obj is CharSet)
        {
            CharSet other = (CharSet)obj;
            return this == other;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return _chars.GetHashCode();
    }
}