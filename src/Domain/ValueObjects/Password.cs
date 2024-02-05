﻿namespace CashFlowAPI.Domain.ValueObjects;
public sealed class Password
{
    public string Value { get; set; }

    public Password() { }
    public Password(string value)
    {
        this.Value = value ?? throw new ArgumentNullException(nameof(Password));
    }
}