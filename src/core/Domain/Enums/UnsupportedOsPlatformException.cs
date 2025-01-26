﻿namespace Vordr.Domain.Enums;

public class UnsupportedOsPlatformException : Exception
{
    public UnsupportedOsPlatformException()
    {
    }

    public UnsupportedOsPlatformException(string message)
        : base(message)
    {
    }

    public UnsupportedOsPlatformException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
