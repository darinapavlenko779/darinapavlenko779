using System.Collections.Generic;

/// <summary>
/// One level: what sits in each of the twenty cells, which way every mirror is
/// turned, and the route the designer-of-record (the generator) built it from.
///
/// Plain data, no MonoBehaviour - it is handed to views and to the solver, so it is
/// public to keep it out of CS0051 territory.
/// </summary>
public sealed class _0xc136060f
{
    public const int KindEmitter = 5;
    public const int KindInert = 0;
    public int EmitterCell;
    public const int KindMirror = 1;
    public int MoveBudget;
    public bool _0x6534485a(int _0x1c46e0d2)
    {
        return _0x1c46e0d2 >= 0 && _0x1c46e0d2 < _0x0f96bb7d.Cells && this.Kind[_0x1c46e0d2] == KindMirror;
    }

    public int Level;
    public readonly int[] Kind = new int[_0x0f96bb7d.Cells];
    public readonly List<int> Route = new List<int>(12);
    public readonly int[] Solved = new int[_0x0f96bb7d.Cells];
    public _0xc136060f()
    {
        for (int _0xeaca5521 = 0; _0xeaca5521 < _0x0f96bb7d.Cells; _0xeaca5521++)
            this.Solved[_0xeaca5521] = -1;
    }

    public const int KindCrystal = 4;
    public int SolutionTaps;
    public readonly List<int> Checkpoints = new List<int>(4);
    public void _0xe2e97a79(int _0x5751e855)
    {
        if (!this._0x6534485a(_0x5751e855))
            return;
        this.State[_0x5751e855] = (this.State[_0x5751e855] + 1) % _0x0f96bb7d.Axes;
    }

    public int EmitterDirection;
    /// <summary>True when every route mirror already stands where the solution wants it.</summary>
    public bool _0x4d1ba36d()
    {
        for (int _0x52ddb3c6 = 0; _0x52ddb3c6 < _0x0f96bb7d.Cells; _0x52ddb3c6++)
            if (this.Solved[_0x52ddb3c6] >= 0 && this.State[_0x52ddb3c6] != this.Solved[_0x52ddb3c6])
                return false;
        return true;
    }

    public readonly int[] State = new int[_0x0f96bb7d.Cells];
    public int CrystalCell;
    public const int KindCheckpoint = 3;
    public const int KindBlocker = 2;
}