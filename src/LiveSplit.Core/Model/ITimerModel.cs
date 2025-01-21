﻿using System;
using System.Collections.Generic;

using LiveSplit.Model.Input;

namespace LiveSplit.Model;

public interface ITimerModel
{
    LiveSplitState CurrentState { get; set; }

    event EventHandler OnSplit;
    event EventHandler OnUndoSplit;
    event EventHandler OnSkipSplit;
    event EventHandler OnStart;
    event EventHandlerT<TimerPhase> OnReset;
    event EventHandler OnPause;
    event EventHandler OnUndoAllPauses;
    event EventHandler OnResume;
    event EventHandler OnScrollUp;
    event EventHandler OnScrollDown;
    event EventHandler OnSwitchComparisonPrevious;
    event EventHandler OnSwitchComparisonNext;

    void Start();
    void InitializeGameTime();
    void Split();
    void SkipSplit();
    void UndoSplit();
    void Reset();
    void Reset(bool updateSplits);
    void ResetAndSetAttemptAsPB();
    void ResetAndUndoAttempt();
    void LoadRun(string gameName, string categoryName, Time time, List<Tuple<string, Time>> segmentList, AtomicDateTime started, bool isGameTimeInitialized, TimeSpan pauseTime);
    void Pause();
    void UndoAllPauses();
    void ScrollUp();
    void ScrollDown();
    void SwitchComparisonPrevious();
    void SwitchComparisonNext();
}
