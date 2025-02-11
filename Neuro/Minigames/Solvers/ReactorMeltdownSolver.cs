﻿using System.Collections;
using Neuro.Cursor;

namespace Neuro.Minigames.Solvers;

[MinigameSolver(typeof(ReactorMinigame))]
public sealed class ReactorMeltdownSolver : TasklessMinigameSolver<ReactorMinigame>
{
    protected override IEnumerator CompleteMinigame(ReactorMinigame minigame)
    {
        yield return InGameCursor.Instance.CoMoveTo(minigame.hand);
        minigame.ButtonDown();
    }
}
