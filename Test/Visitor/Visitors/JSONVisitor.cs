﻿
using Lessons.Visitor.Clients;

namespace Lessons.Visitor.Visitors;

public class JSONVisitor : IVisitor
{
    public string Serialize(Company company)
    {
        return string.Empty;
    }

    public string Serialize(Person person)
    {
        return string.Empty;
    }
}
