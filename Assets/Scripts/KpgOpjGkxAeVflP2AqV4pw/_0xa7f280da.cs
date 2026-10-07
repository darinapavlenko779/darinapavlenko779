using System.Collections.Generic;

/// <summary>
/// Walks the beam from the emitter and reports where it ends up.
///
/// Every cell is one of six things, so a step is a lookup rather than a simulation:
/// a mirror turns the beam by the closed arithmetic in HexMath, a checkpoint and an
/// inert tile let it pass, a blocker swallows it, the crystal ends the run. The step
/// budget is the guard against a mirror pair bouncing the beam forever.
/// </summary>
public sealed class _0xa7f280da
{
    public bool ReachedCrystal;
    public readonly List<int> LitCheckpoints = new List<int>(4);
    public bool HitBlocker;
    public void _0xc84e8214(_0xc136060f _0xe8989de8)
    {
        this.Path.Clear();
        this.LitCheckpoints.Clear();
        this.ReachedCrystal = false;
        this.HitBlocker = false;
        if (_0xe8989de8 == null)
            return;
        int _0x82cc9bd9 = _0x0f96bb7d.ColumnOf(_0xe8989de8.EmitterCell);
        int _0x8f99a44c = _0x0f96bb7d.RowOf(_0xe8989de8.EmitterCell);
        int _0xd6178f8f = _0xe8989de8.EmitterDirection;
        this.Path.Add(_0xe8989de8.EmitterCell);
        for (int _0x38a65a36 = 0; _0x38a65a36 < StepBudget; _0x38a65a36++)
        {
            int _0x414fdcbb = _0x0f96bb7d.StepColumn(_0x82cc9bd9, _0x8f99a44c, _0xd6178f8f);
            int _0x35f32143 = _0x0f96bb7d.StepRow(_0x8f99a44c, _0xd6178f8f);
            if (!_0x0f96bb7d.Inside(_0x414fdcbb, _0x35f32143))
                return; // the beam leaves the lattice
            _0x82cc9bd9 = _0x414fdcbb;
            _0x8f99a44c = _0x35f32143;
            int _0xd73e7f92 = _0x0f96bb7d.Index(_0x82cc9bd9, _0x8f99a44c);
            this.Path.Add(_0xd73e7f92);
            int _0x362aa2d8 = _0xe8989de8.Kind[_0xd73e7f92];
            if (_0x362aa2d8 == _0xc136060f.KindBlocker)
            {
                this.HitBlocker = true;
                return;
            }

            if (_0x362aa2d8 == _0xc136060f.KindCrystal)
            {
                this.ReachedCrystal = true;
                return;
            }

            if (_0x362aa2d8 == _0xc136060f.KindEmitter)
                return;
            if (_0x362aa2d8 == _0xc136060f.KindCheckpoint)
            {
                if (!this.LitCheckpoints.Contains(_0xd73e7f92))
                    this.LitCheckpoints.Add(_0xd73e7f92);
                continue;
            }

            if (_0x362aa2d8 == _0xc136060f.KindMirror)
            {
                int _0x6ef39f8b = _0x0f96bb7d.Reflect(_0xd6178f8f, _0xe8989de8.State[_0xd73e7f92]);
                if (_0x6ef39f8b < 0)
                    return; // mirror square across the beam
                _0xd6178f8f = _0x6ef39f8b;
            }
        }
    }

    public readonly List<int> Path = new List<int>(StepBudget);
    /// <summary>Every required checkpoint lit AND the crystal reached.</summary>
    public bool _0x40eeaf7b(_0xc136060f _0xd1270f8d)
    {
        if (_0xd1270f8d == null || !this.ReachedCrystal)
            return false;
        for (int _0x1c514bbb = 0; _0x1c514bbb < _0xd1270f8d.Checkpoints.Count; _0x1c514bbb++)
            if (!this.LitCheckpoints.Contains(_0xd1270f8d.Checkpoints[_0x1c514bbb]))
                return false;
        return true;
    }

    private const int StepBudget = 64;
    public bool _0x006dcb38(int _0x9231c62d)
    {
        return this.LitCheckpoints.Contains(_0x9231c62d);
    }
}