﻿
using System;

namespace Lessons.Observer;

public interface IObservable
{
    public void AddObserver(IObserver observer);
    public void RemoveObserver(IObserver observer);
    public void NotifyObserver();
}
