﻿using System.Collections;
using Neuro.Cursor;
using Neuro.Utilities;

namespace Neuro.Minigames.Solvers;

[MinigameSolver(typeof(SweepMinigame))]
public sealed class CalibrateDistributorSolver : MinigameSolver<SweepMinigame>
{
    protected override IEnumerator CompleteMinigame(SweepMinigame minigame, NormalPlayerTask task)
    {
        while (minigame.spinnerIdx < minigame.Gauges.Length)
        {
            yield return InGameCursor.Instance.CoMoveTo(minigame.ControllerSelectable.At(minigame.spinnerIdx));
            if (minigame.CalcXPerc() is > 6 and < 13) minigame.HitButton(minigame.spinnerIdx);
        }
    }
}
