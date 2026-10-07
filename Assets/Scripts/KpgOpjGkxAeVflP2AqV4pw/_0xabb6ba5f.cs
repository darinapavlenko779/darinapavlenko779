using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Builds a level CONSTRUCTIVELY (C.11): the solution is laid down first and the
/// board is derived from it, so solvability is a property of the construction and
/// never something we have to hope a random board happens to have.
///
/// 1. pick an emitter on the top row and a crystal on the bottom row;
/// 2. find a simple walk between them with enough corners and enough straights;
/// 3. every corner becomes a mirror standing at exactly the angle that corner needs;
/// 4. straights become the required checkpoints;
/// 5. the cells off the walk take the blockers and the decoy mirrors;
/// 6. each route mirror is turned BACK by one to three taps, so the opening board is
///    never already solved, and the sum of those taps is the par for the level.
///
/// Two anchor cells are guaranteed to hold a mirror in every level, so the review
/// capture can tap them without pinning the route or the difficulty: a walk that
/// crosses an anchor without turning there is rejected rather than patched.
/// </summary>
public sealed class _0xabb6ba5f
{
    private int _0x0888dc0d;
    private void _0x8662c30c(_0xc136060f _0x29621051, int _0x623ba3b3, List<int> _0xb3ca8b7a)
    {
        int _0x4025dc9d = Mathf.Clamp(2 + _0x623ba3b3 / 5, 2, 4);
        if (_0x4025dc9d > _0xb3ca8b7a.Count)
            _0x4025dc9d = _0xb3ca8b7a.Count;
        for (int _0x4f04b866 = _0xb3ca8b7a.Count - 1; _0x4f04b866 > 0; _0x4f04b866--)
        {
            int _0x271d656f = this._0x06e03520.Next(_0x4f04b866 + 1);
            int _0x4c030fd0 = _0xb3ca8b7a[_0x4f04b866];
            _0xb3ca8b7a[_0x4f04b866] = _0xb3ca8b7a[_0x271d656f];
            _0xb3ca8b7a[_0x271d656f] = _0x4c030fd0;
        }

        for (int _0xc58a79c3 = 0; _0xc58a79c3 < _0x4025dc9d; _0xc58a79c3++)
        {
            _0x29621051.Kind[_0xb3ca8b7a[_0xc58a79c3]] = _0xc136060f.KindCheckpoint;
            _0x29621051.Checkpoints.Add(_0xb3ca8b7a[_0xc58a79c3]);
        }

        _0x29621051.Checkpoints.Sort();
    }

    private readonly int[] _0xfde8b5af = new int[_0x0f96bb7d.Cells];
    // ---------------------------------------------------------------- composition
    private _0xc136060f _0x7d693a8d(int _0xa0e0c577, bool _0x5f8c5bbb)
    {
        int _0x58756528 = this._0x06e03520.Next(_0x0f96bb7d.Cols);
        int _0xd088d999 = this._0x06e03520.Next(_0x0f96bb7d.Cols);
        this._0x562d2369 = Mathf.Clamp(7 + _0xa0e0c577 / 4, 7, 9);
        this._0x364bba05 = Mathf.Clamp(this._0x562d2369 + 3, 8, 13);
        this._0x5321bb7b = _0xd088d999;
        this._0xe7f09163 = _0x0f96bb7d.Rows - 1;
        this._0x0888dc0d = 4000;
        this._0xa04281c0 = 0;
        for (int _0x3d2a3599 = 0; _0x3d2a3599 < _0x0f96bb7d.Cells; _0x3d2a3599++)
            this._0x76b29ebd[_0x3d2a3599] = false;
        if (!this._0x6c435d61(_0x58756528, 0))
            return null;
        _0xc136060f _0xdb568246 = new _0xc136060f();
        _0xdb568246.Level = _0xa0e0c577;
        for (int _0xe5d4cc2d = 0; _0xe5d4cc2d < this._0xa04281c0; _0xe5d4cc2d++)
            _0xdb568246.Route.Add(this._0xfde8b5af[_0xe5d4cc2d]);
        if (_0x5f8c5bbb && !_0xdb568246.Route.Contains(_0x4b5a6b0e) && !_0xdb568246.Route.Contains(_0xc69c3d5d))
            return null;
        int _0x7fb56825 = _0x0f96bb7d.DirectionBetween(_0x58756528, 0, _0x0f96bb7d.ColumnOf(this._0xfde8b5af[1]), _0x0f96bb7d.RowOf(this._0xfde8b5af[1]));
        if (_0x7fb56825 != _0x0f96bb7d.SouthEast && _0x7fb56825 != _0x0f96bb7d.SouthWest)
            return null; // the emitter must shine inwards
        _0xdb568246.EmitterCell = this._0xfde8b5af[0];
        _0xdb568246.EmitterDirection = _0x7fb56825;
        _0xdb568246.CrystalCell = this._0xfde8b5af[this._0xa04281c0 - 1];
        _0xdb568246.Kind[_0xdb568246.EmitterCell] = _0xc136060f.KindEmitter;
        _0xdb568246.Kind[_0xdb568246.CrystalCell] = _0xc136060f.KindCrystal;
        List<int> _0xf9202a19 = new List<int>(8);
        List<int> _0x9715a5a6 = new List<int>(8);
        if (!this._0xcf157be7(_0xdb568246, _0xf9202a19, _0x9715a5a6))
            return null;
        if (_0xf9202a19.Count < 2 || _0xf9202a19.Count > 6 || _0x9715a5a6.Count < 2)
            return null;
        this._0x8662c30c(_0xdb568246, _0xa0e0c577, _0x9715a5a6);
        this._0x3f04e12e(_0xdb568246, _0xa0e0c577);
        if (!this._0xa6177a55(_0xdb568246))
            return null;
        return this._0xf54f60ac(_0xdb568246, _0xa0e0c577, _0xf9202a19) ? _0xdb568246 : null;
    }

    private int _0xe7f09163;
    private static readonly int _0xc69c3d5d = _0x0f96bb7d.Index(2, 3);
    public _0xc136060f _0x31647424(int _0x9eaa080a, int _0x74884d41)
    {
        int _0x87a264c4 = Mathf.Clamp(_0x9eaa080a, 0, LevelCount - 1);
        int _0x6a65ea93 = (_0x87a264c4 * 7919) ^ ((_0x74884d41 + 1) * 104729);
        this._0x06e03520 = new System.Random(_0x6a65ea93);
        {
#if B_LOGS
            {
                Debug.Log($"[lattice] level={_0x87a264c4} attempt={_0x74884d41} seed={_0x6a65ea93}");
            }
#endif
        }

        // The first pass also insists that the route itself runs through an anchor, so
        // a tap there re-routes the beam instead of only turning a decoy. If no seed
        // obliges, the second pass drops that preference rather than the level.
        for (int _0x913307cb = 0; _0x913307cb < 64; _0x913307cb++)
        {
            _0xc136060f _0x4b80b75f = this._0x7d693a8d(_0x87a264c4, _0x913307cb < 40);
            if (_0x4b80b75f != null)
                return _0x4b80b75f;
        }

        return this._0x4e9ba1b6(_0x87a264c4);
    }

    /// <summary>
    /// Turns each route mirror back by one to three taps - never zero, or the level
    /// would open already solved - and makes sure at least one needs two or more.
    /// The opening board must also not be sitting in a blocker, which would read as a
    /// penalty the player never earned.
    /// </summary>
    private bool _0xf54f60ac(_0xc136060f _0x382614ab, int _0xeb3152a7, List<int> _0x81377ec7)
    {
        int[] cost = new int[_0x81377ec7.Count];
        // A three-tap scramble on every corner of a long route would push par past the
        // move ceiling and make the level unwinnable by construction, so deep corners
        // are only handed out while the route is short enough to afford them.
        int _0x7f1456b8 = _0x81377ec7.Count >= 5 ? 3 : 4;
        for (int _0x497e3c27 = 0; _0x497e3c27 < 24; _0x497e3c27++)
        {
            int _0x460f6cf0 = 0;
            bool _0x655ee756 = false;
            for (int _0xc34fb0cc = 0; _0xc34fb0cc < _0x81377ec7.Count; _0xc34fb0cc++)
            {
                cost[_0xc34fb0cc] = this._0x06e03520.Next(1, _0x7f1456b8);
                if (cost[_0xc34fb0cc] >= 2)
                    _0x655ee756 = true;
                _0x460f6cf0 += cost[_0xc34fb0cc];
            }

            if (!_0x655ee756)
            {
                cost[this._0x06e03520.Next(_0x81377ec7.Count)] = 2;
                _0x460f6cf0 = 0;
                for (int _0xf5c7f9d9 = 0; _0xf5c7f9d9 < _0x81377ec7.Count; _0xf5c7f9d9++)
                    _0x460f6cf0 += cost[_0xf5c7f9d9];
            }

            for (int _0x5423a4c4 = 0; _0x5423a4c4 < _0x81377ec7.Count; _0x5423a4c4++)
            {
                int _0xaa8ab846 = _0x81377ec7[_0x5423a4c4];
                _0x382614ab.State[_0xaa8ab846] = ((_0x382614ab.Solved[_0xaa8ab846] - cost[_0x5423a4c4]) % _0x0f96bb7d.Axes + _0x0f96bb7d.Axes) % _0x0f96bb7d.Axes;
            }

            this._0xe2d32631._0xc84e8214(_0x382614ab);
            if (this._0xe2d32631._0x40eeaf7b(_0x382614ab) || this._0xe2d32631.HitBlocker)
                continue;
            _0x382614ab.SolutionTaps = _0x460f6cf0;
            int _0xebb92c5d = _0xeb3152a7 < 3 ? 3 : (_0xeb3152a7 < 8 ? 2 : 1);
            _0x382614ab.MoveBudget = Mathf.Max(Mathf.Clamp(_0x460f6cf0 + _0xebb92c5d, 6, 18), _0x460f6cf0 + 1);
            return true;
        }

        return false;
    }

    private int _0x364bba05;
    private readonly _0xa7f280da _0xe2d32631 = new _0xa7f280da();
    /// <summary>Corners become mirrors at the exact angle the corner needs; straights stay open.</summary>
    private bool _0xcf157be7(_0xc136060f _0xc5685db1, List<int> _0x9a26417a, List<int> _0x003cba85)
    {
        for (int _0xf74ea57d = 1; _0xf74ea57d < this._0xa04281c0 - 1; _0xf74ea57d++)
        {
            int _0x2141c316 = this._0xfde8b5af[_0xf74ea57d - 1];
            int _0x037ffed4 = this._0xfde8b5af[_0xf74ea57d];
            int _0x11d12a5c = this._0xfde8b5af[_0xf74ea57d + 1];
            int _0x7b28471d = _0x0f96bb7d.DirectionBetween(_0x0f96bb7d.ColumnOf(_0x2141c316), _0x0f96bb7d.RowOf(_0x2141c316), _0x0f96bb7d.ColumnOf(_0x037ffed4), _0x0f96bb7d.RowOf(_0x037ffed4));
            int _0xcdde7077 = _0x0f96bb7d.DirectionBetween(_0x0f96bb7d.ColumnOf(_0x037ffed4), _0x0f96bb7d.RowOf(_0x037ffed4), _0x0f96bb7d.ColumnOf(_0x11d12a5c), _0x0f96bb7d.RowOf(_0x11d12a5c));
            if (_0x7b28471d < 0 || _0xcdde7077 < 0)
                return false;
            if (_0x7b28471d == _0xcdde7077)
            {
                if (_0x037ffed4 == _0x4b5a6b0e || _0x037ffed4 == _0xc69c3d5d)
                    return false; // an anchor must be a mirror or absent
                _0x003cba85.Add(_0x037ffed4);
                continue;
            }

            _0xc5685db1.Kind[_0x037ffed4] = _0xc136060f.KindMirror;
            _0xc5685db1.Solved[_0x037ffed4] = _0x0f96bb7d.StateForTurn(_0x7b28471d, _0xcdde7077);
            _0x9a26417a.Add(_0x037ffed4);
        }

        return true;
    }

    /// <summary>
    /// Fills the cells the walk never touches. The anchors come first so they always
    /// end up holding a mirror, decoy or not.
    /// </summary>
    private void _0x3f04e12e(_0xc136060f _0x602a43e8, int _0x4eab607f)
    {
        List<int> _0xb92fa682 = new List<int>(_0x0f96bb7d.Cells);
        for (int _0x5851dbce = 0; _0x5851dbce < _0x0f96bb7d.Cells; _0x5851dbce++)
            if (!_0x602a43e8.Route.Contains(_0x5851dbce))
                _0xb92fa682.Add(_0x5851dbce);
        for (int _0x4e697e63 = _0xb92fa682.Count - 1; _0x4e697e63 > 0; _0x4e697e63--)
        {
            int _0x1a048a6c = this._0x06e03520.Next(_0x4e697e63 + 1);
            int _0x1b3e9cca = _0xb92fa682[_0x4e697e63];
            _0xb92fa682[_0x4e697e63] = _0xb92fa682[_0x1a048a6c];
            _0xb92fa682[_0x1a048a6c] = _0x1b3e9cca;
        }

        if (_0xb92fa682.Contains(_0x4b5a6b0e))
        {
            _0x602a43e8.Kind[_0x4b5a6b0e] = _0xc136060f.KindMirror;
            _0x602a43e8.State[_0x4b5a6b0e] = this._0x06e03520.Next(_0x0f96bb7d.Axes);
            _0xb92fa682.Remove(_0x4b5a6b0e);
        }

        if (_0xb92fa682.Contains(_0xc69c3d5d))
        {
            _0x602a43e8.Kind[_0xc69c3d5d] = _0xc136060f.KindMirror;
            _0x602a43e8.State[_0xc69c3d5d] = this._0x06e03520.Next(_0x0f96bb7d.Axes);
            _0xb92fa682.Remove(_0xc69c3d5d);
        }

        int _0x29f67632 = Mathf.Min(Mathf.Clamp(1 + _0x4eab607f / 3, 1, 5), _0xb92fa682.Count);
        for (int _0xb7023828 = 0; _0xb7023828 < _0x29f67632; _0xb7023828++)
        {
            _0x602a43e8.Kind[_0xb92fa682[0]] = _0xc136060f.KindBlocker;
            _0xb92fa682.RemoveAt(0);
        }

        int _0xc87afd34 = Mathf.Min(Mathf.Clamp(1 + _0x4eab607f / 4, 1, 4), _0xb92fa682.Count);
        for (int _0xb2ae28e2 = 0; _0xb2ae28e2 < _0xc87afd34; _0xb2ae28e2++)
        {
            _0x602a43e8.Kind[_0xb92fa682[0]] = _0xc136060f.KindMirror;
            _0x602a43e8.State[_0xb92fa682[0]] = this._0x06e03520.Next(_0x0f96bb7d.Axes);
            _0xb92fa682.RemoveAt(0);
        }
    }

    private static readonly int _0x4b5a6b0e = _0x0f96bb7d.Index(1, 1);
    private void _0xa05829fa()
    {
        for (int _0x98334c7e = 0; _0x98334c7e < _0x0f96bb7d.Axes; _0x98334c7e++)
            this._0x4ce4162d[_0x98334c7e] = _0x98334c7e;
        for (int _0x30662205 = _0x0f96bb7d.Axes - 1; _0x30662205 > 0; _0x30662205--)
        {
            int _0xf5d7e91e = this._0x06e03520.Next(_0x30662205 + 1);
            int _0xa2b7f7a9 = this._0x4ce4162d[_0x30662205];
            this._0x4ce4162d[_0x30662205] = this._0x4ce4162d[_0xf5d7e91e];
            this._0x4ce4162d[_0xf5d7e91e] = _0xa2b7f7a9;
        }
    }

    private int _0x5321bb7b;
    // ------------------------------------------------------------------- fallback
    /// <summary>
    /// The guaranteed level. It exists so a pathological seed can never leave the
    /// player without a board - it is the safety net, not the game (C.11).
    /// </summary>
    private _0xc136060f _0x4e9ba1b6(int _0x0623fc62)
    {
        _0xc136060f _0x19fb1cb1 = new _0xc136060f();
        _0x19fb1cb1.Level = _0x0623fc62;
        int[] _0xaf4d7f03 =
        {
            _0x0f96bb7d.Index(0, 0),
            _0x0f96bb7d.Index(1, 0),
            _0x0f96bb7d.Index(2, 0),
            _0x0f96bb7d.Index(3, 0),
            _0x0f96bb7d.Index(3, 1),
            _0x0f96bb7d.Index(3, 2),
            _0x0f96bb7d.Index(2, 2),
            _0x0f96bb7d.Index(1, 2),
            _0x0f96bb7d.Index(0, 3),
            _0x0f96bb7d.Index(1, 4),
        };
        for (int _0x8d864b42 = 0; _0x8d864b42 < _0xaf4d7f03.Length; _0x8d864b42++)
            _0x19fb1cb1.Route.Add(_0xaf4d7f03[_0x8d864b42]);
        _0x19fb1cb1.EmitterCell = _0xaf4d7f03[0];
        _0x19fb1cb1.EmitterDirection = _0x0f96bb7d.East;
        _0x19fb1cb1.CrystalCell = _0xaf4d7f03[_0xaf4d7f03.Length - 1];
        _0x19fb1cb1.Kind[_0x19fb1cb1.EmitterCell] = _0xc136060f.KindEmitter;
        _0x19fb1cb1.Kind[_0x19fb1cb1.CrystalCell] = _0xc136060f.KindCrystal;
        for (int _0x8b3ffb1a = 1; _0x8b3ffb1a < _0xaf4d7f03.Length - 1; _0x8b3ffb1a++)
        {
            int _0xd3226461 = _0xaf4d7f03[_0x8b3ffb1a - 1];
            int _0xc2b4779b = _0xaf4d7f03[_0x8b3ffb1a];
            int _0xf95aea70 = _0xaf4d7f03[_0x8b3ffb1a + 1];
            int _0xf7cf25b8 = _0x0f96bb7d.DirectionBetween(_0x0f96bb7d.ColumnOf(_0xd3226461), _0x0f96bb7d.RowOf(_0xd3226461), _0x0f96bb7d.ColumnOf(_0xc2b4779b), _0x0f96bb7d.RowOf(_0xc2b4779b));
            int _0x839d686e = _0x0f96bb7d.DirectionBetween(_0x0f96bb7d.ColumnOf(_0xc2b4779b), _0x0f96bb7d.RowOf(_0xc2b4779b), _0x0f96bb7d.ColumnOf(_0xf95aea70), _0x0f96bb7d.RowOf(_0xf95aea70));
            if (_0xf7cf25b8 == _0x839d686e)
            {
                _0x19fb1cb1.Kind[_0xc2b4779b] = _0xc136060f.KindCheckpoint;
                _0x19fb1cb1.Checkpoints.Add(_0xc2b4779b);
                continue;
            }

            _0x19fb1cb1.Kind[_0xc2b4779b] = _0xc136060f.KindMirror;
            _0x19fb1cb1.Solved[_0xc2b4779b] = _0x0f96bb7d.StateForTurn(_0xf7cf25b8, _0x839d686e);
        }

        _0x19fb1cb1.Kind[_0x4b5a6b0e] = _0xc136060f.KindMirror;
        _0x19fb1cb1.State[_0x4b5a6b0e] = 1;
        _0x19fb1cb1.Kind[_0xc69c3d5d] = _0xc136060f.KindMirror;
        _0x19fb1cb1.State[_0xc69c3d5d] = 4;
        _0x19fb1cb1.Kind[_0x0f96bb7d.Index(0, 2)] = _0xc136060f.KindBlocker;
        _0x19fb1cb1.Kind[_0x0f96bb7d.Index(3, 3)] = _0xc136060f.KindBlocker;
        _0x19fb1cb1.Kind[_0x0f96bb7d.Index(2, 4)] = _0xc136060f.KindBlocker;
        int _0x113b994b = 0;
        int _0xc2a0007d = 1;
        for (int _0x5ce82091 = 0; _0x5ce82091 < _0x0f96bb7d.Cells; _0x5ce82091++)
        {
            if (_0x19fb1cb1.Solved[_0x5ce82091] < 0)
                continue;
            int cost = 1 + (_0xc2a0007d % 3);
            _0xc2a0007d++;
            _0x113b994b += cost;
            _0x19fb1cb1.State[_0x5ce82091] = ((_0x19fb1cb1.Solved[_0x5ce82091] - cost) % _0x0f96bb7d.Axes + _0x0f96bb7d.Axes) % _0x0f96bb7d.Axes;
        }

        _0x19fb1cb1.SolutionTaps = _0x113b994b;
        _0x19fb1cb1.MoveBudget = Mathf.Clamp(_0x113b994b + 3, 6, 18);
        return _0x19fb1cb1;
    }

    /// <summary>
    /// Randomised depth-first search for a simple walk. The board is twenty cells, so
    /// the expansion budget exists only to keep a pathological ordering cheap.
    /// </summary>
    private bool _0x6c435d61(int _0x5ecd4ecf, int _0x29199eee)
    {
        int _0xed5d57ec = _0x0f96bb7d.Index(_0x5ecd4ecf, _0x29199eee);
        this._0xfde8b5af[this._0xa04281c0++] = _0xed5d57ec;
        this._0x76b29ebd[_0xed5d57ec] = true;
        bool _0xdf84d89a = false;
        if (_0x5ecd4ecf == this._0x5321bb7b && _0x29199eee == this._0xe7f09163)
        {
            _0xdf84d89a = this._0xa04281c0 >= this._0x562d2369;
        }
        else if (this._0xa04281c0 < this._0x364bba05 && this._0x0888dc0d-- > 0)
        {
            this._0xa05829fa();
            for (int _0xeb4d7cd6 = 0; _0xeb4d7cd6 < _0x0f96bb7d.Axes && !_0xdf84d89a; _0xeb4d7cd6++)
            {
                int _0x5bcbdb62 = this._0x4ce4162d[_0xeb4d7cd6];
                int _0x81f13158 = _0x0f96bb7d.StepColumn(_0x5ecd4ecf, _0x29199eee, _0x5bcbdb62);
                int _0x9a9fd1b4 = _0x0f96bb7d.StepRow(_0x29199eee, _0x5bcbdb62);
                if (!_0x0f96bb7d.Inside(_0x81f13158, _0x9a9fd1b4))
                    continue;
                if (this._0x76b29ebd[_0x0f96bb7d.Index(_0x81f13158, _0x9a9fd1b4)])
                    continue;
                if (_0x9a9fd1b4 == 0)
                    continue; // the emitter row is the start, never a stop
                _0xdf84d89a = this._0x6c435d61(_0x81f13158, _0x9a9fd1b4);
            }
        }

        if (!_0xdf84d89a)
        {
            this._0xa04281c0--;
            this._0x76b29ebd[_0xed5d57ec] = false;
        }

        return _0xdf84d89a;
    }

    private System.Random _0x06e03520;
    private readonly bool[] _0x76b29ebd = new bool[_0x0f96bb7d.Cells];
    public const int LevelCount = 12;
    private int _0xa04281c0;
    private int _0x562d2369;
    private readonly int[] _0x4ce4162d = new int[_0x0f96bb7d.Axes];
    /// <summary>Stand every route mirror where the solution wants it and check the beam agrees.</summary>
    private bool _0xa6177a55(_0xc136060f _0x072b3e33)
    {
        for (int _0x35bafc4e = 0; _0x35bafc4e < _0x0f96bb7d.Cells; _0x35bafc4e++)
            if (_0x072b3e33.Solved[_0x35bafc4e] >= 0)
                _0x072b3e33.State[_0x35bafc4e] = _0x072b3e33.Solved[_0x35bafc4e];
        this._0xe2d32631._0xc84e8214(_0x072b3e33);
        return this._0xe2d32631._0x40eeaf7b(_0x072b3e33);
    }
}