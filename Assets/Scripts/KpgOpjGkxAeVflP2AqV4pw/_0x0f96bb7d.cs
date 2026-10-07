using UnityEngine;

/// <summary>
/// The closed arithmetic of the lattice: a pointy-top honeycomb of 4 columns by 5
/// rows, odd rows offset half a cell to the right, and six travel axes.
///
/// Direction index d means an angle of d*60 degrees measured counter-clockwise from
/// east, so 0=E, 1=NE, 2=NW, 3=W, 4=SW, 5=SE. Row 0 is the TOP row and the row index
/// grows downwards, which is why NE/NW decrease the row.
///
/// A mirror holds six states. Its reflecting plane sits at 90 + state*30 degrees -
/// state 0 is the vertical bar the sprite is drawn with - so the outgoing direction
/// is 2*plane - incoming = 180 + 60*state - 60*d degrees, i.e. (3 + state - d) mod 6.
/// Twice a multiple of 30 is always a multiple of 60, so a reflection can never leave
/// the six axes; the only special case is the mirror standing square across the beam,
/// which sends it straight back and is treated as the beam dying.
/// </summary>
public static class _0x0f96bb7d
{
    public static int RowOf(int _0x1158e236)
    {
        return _0x1158e236 / Cols;
    }

    public const int SouthEast = 5;
    public const int Axes = 6;
    public static int Opposite(int _0x84ab557d)
    {
        return (_0x84ab557d + 3) % Axes;
    }

    public const int Cols = 4;
    /// <summary>Taps only ever turn a mirror one step forward, so the cost is one-way.</summary>
    public static int TapsBetween(int _0xc940b1ed, int _0x47bc581c)
    {
        return ((_0x47bc581c - _0xc940b1ed) % Axes + Axes) % Axes;
    }

    public static int Index(int _0x1c794d27, int _0x627d163d)
    {
        return _0x627d163d * Cols + _0x1c794d27;
    }

    public const int West = 3;
    public static bool Inside(int _0x2b9b33f9, int _0xe278c0b4)
    {
        return _0x2b9b33f9 >= 0 && _0x2b9b33f9 < Cols && _0xe278c0b4 >= 0 && _0xe278c0b4 < Rows;
    }

    /// <summary>The direction from one cell to an adjacent one, or -1 if they are not neighbours.</summary>
    public static int DirectionBetween(int _0x91b74e59, int _0x41720b16, int _0x67da9dde, int _0xef7740f4)
    {
        for (int _0xc82da0e8 = 0; _0xc82da0e8 < Axes; _0xc82da0e8++)
            if (StepColumn(_0x91b74e59, _0x41720b16, _0xc82da0e8) == _0x67da9dde && StepRow(_0x41720b16, _0xc82da0e8) == _0xef7740f4)
                return _0xc82da0e8;
        return -1;
    }

    public const int NorthEast = 1;
    public static int ColumnOf(int _0x943cdf34)
    {
        return _0x943cdf34 % Cols;
    }

    /// <summary>The Z rotation of a mirror tile sprite in a given state.</summary>
    public static float MirrorSpin(int _0x29eb87e2)
    {
        return _0x29eb87e2 * 30f;
    }

    /// <summary>Column of the neighbour in direction d. Odd rows lean half a cell right.</summary>
    public static int StepColumn(int _0x6461149c, int _0x3c2e234e, int _0x8a50614f)
    {
        bool _0xf395142a = (_0x3c2e234e & 1) == 1;
        switch (_0x8a50614f)
        {
            case East:
                return _0x6461149c + 1;
            case West:
                return _0x6461149c - 1;
            case NorthEast:
                return _0xf395142a ? _0x6461149c + 1 : _0x6461149c;
            case NorthWest:
                return _0xf395142a ? _0x6461149c : _0x6461149c - 1;
            case SouthWest:
                return _0xf395142a ? _0x6461149c : _0x6461149c - 1;
            case SouthEast:
                return _0xf395142a ? _0x6461149c + 1 : _0x6461149c;
            default:
                return _0x6461149c;
        }
    }

    public const int Cells = Cols * Rows;
    /// <summary>The mirror state that turns an incoming direction into an outgoing one.</summary>
    public static int StateForTurn(int _0xccf22e5f, int _0x4f81249d)
    {
        return ((_0x4f81249d + _0xccf22e5f - 3) % Axes + Axes) % Axes;
    }

    public static int StepRow(int _0xfac25cd8, int _0xb610bb03)
    {
        switch (_0xb610bb03)
        {
            case NorthEast:
            case NorthWest:
                return _0xfac25cd8 - 1;
            case SouthWest:
            case SouthEast:
                return _0xfac25cd8 + 1;
            default:
                return _0xfac25cd8;
        }
    }

    public const int Rows = 5;
    public static float AxisAngle(int _0xe10b34d8)
    {
        return _0xe10b34d8 * 60f;
    }

    public const int NorthWest = 2;
    /// <summary>
    /// Where a beam travelling in <paramref name = "direction"/> leaves a mirror in
    /// <paramref name = "state"/>. Returns -1 when the mirror stands square across the
    /// beam and throws it straight back: that is a dead end, not a defeat.
    /// </summary>
    public static int Reflect(int _0xb263d8e7, int _0xcef707d5)
    {
        int _0xe74d08fd = ((3 + _0xcef707d5 - _0xb263d8e7) % Axes + Axes) % Axes;
        return _0xe74d08fd == Opposite(_0xb263d8e7) ? -1 : _0xe74d08fd;
    }

    public const int East = 0;
    public const int SouthWest = 4;
}