﻿
namespace Lessons.Command;

public abstract class Command
{
    public abstract void Execute();
    public abstract void Undo();
}
