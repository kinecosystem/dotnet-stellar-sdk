// This file was modified by Kin Ecosystem (2019)


/*
 *  Copyright 2014 Jonathan Bradshaw. All rights reserved.
 *  Redistribution and use in source and binary forms, with or without modification, is permitted.
 */

namespace kin_base
{
    public sealed partial class EventSource
    {
        /// <summary>
        ///     The possible values of the readyState property.
        /// </summary>
        public enum EventSourceState
        {
            Connecting = 0,
            Open = 1,
            Closed = 2,
            Shutdown = 3
        }
    }
}