// Copyright (c) 2014 Jonathan Magnan (http://jonathanmagnan.com).
// All rights reserved (http://jonathanmagnan.com/extension-methods-library).
// Licensed under MIT License (MIT) (http://zextensionmethods.codeplex.com/license).

using System;
using System.Net;

public static partial class Int16Extension
{
    /// <summary>
    ///     Converts a short value from host byte order to network byte order.
    /// </summary>
    /// <param name="host">The number to convert, expressed in host byte order.</param>
    /// <returns>A short value, expressed in network byte order.</returns>
    public static Int16 HostToNetworkOrder(this Int16 host)
    {
        return IPAddress.HostToNetworkOrder(host);
    }
}