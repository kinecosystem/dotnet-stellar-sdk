// This file was modified by Kin Ecosystem (2019)


/*
 *  Copyright 2014 Jonathan Bradshaw. All rights reserved.
 *  Redistribution and use in source and binary forms, with or without modification, is permitted.
 */

using System;

namespace Kin.Base
{
    public sealed partial class EventSource
    {
        /// <summary>
        ///     Server Sent Event Message Object
        /// </summary>
        public sealed class ServerSentEventArgs : EventArgs
        {
            /// <summary>
            ///     Gets the data.
            /// </summary>
            public string Data { get; set; }
        }
    }
}
