﻿using System;

namespace RaspberrySharp.IO.GeneralPurpose
{
    /// <summary>
    /// Represents a set of pins on the Raspberry Pi Processor
    /// </summary>
    [Flags]
    public enum ProcessorPins : ulong
    {
        /// <summary>
        /// No pins selected.
        /// </summary>
        None = 0,

        /// <summary>
        /// Pin 0 selected.
        /// </summary>
        Pin0 = 1 << 0,

        /// <summary>
        /// Pin 0 selected.
        /// </summary>
        Pin00 = Pin0,

        /// <summary>
        /// Pin 1 selected.
        /// </summary>
        Pin1 = 1 << 1,

        /// <summary>
        /// Pin 1 selected.
        /// </summary>
        Pin01 = Pin1,

        /// <summary>
        /// Pin 2 selected.
        /// </summary>
        Pin2 = 1 << 2,

        /// <summary>
        /// Pin 2 selected.
        /// </summary>
        Pin02 = Pin2,

        /// <summary>
        /// Pin 3 selected.
        /// </summary>
        Pin3 = 1 << 3,

        /// <summary>
        /// Pin 3 selected.
        /// </summary>
        Pin03 = Pin3,

        /// <summary>
        /// Pin 4 selected.
        /// </summary>
        Pin4 = 1 << 4,

        /// <summary>
        /// Pin 4 selected.
        /// </summary>
        Pin04 = Pin4,

        /// <summary>
        /// Pin 7 selected.
        /// </summary>
        Pin7 = 1 << 7,

        /// <summary>
        /// Pin 7 selected.
        /// </summary>
        Pin07 = Pin7,

        /// <summary>
        /// Pin 8 selected.
        /// </summary>
        Pin8 = 1 << 8,

        /// <summary>
        /// Pin 8 selected.
        /// </summary>
        Pin08 = Pin8,

        /// <summary>
        /// Pin 9 selected.
        /// </summary>
        Pin9 = 1 << 9,

        /// <summary>
        /// Pin 9 selected.
        /// </summary>
        Pin09 = Pin9,

        /// <summary>
        /// Pin 10 selected.
        /// </summary>
        Pin10 = 1 << 10,

        /// <summary>
        /// Pin 11 selected.
        /// </summary>
        Pin11 = 1 << 11,

        /// <summary>
        /// Pin 14 selected.
        /// </summary>
        Pin14 = 1 << 14,

        /// <summary>
        /// Pin 15 selected.
        /// </summary>
        Pin15 = 1 << 15,

        /// <summary>
        /// Pin 17 selected.
        /// </summary>
        Pin17 = 1 << 17,

        /// <summary>
        /// Pin 18 selected.
        /// </summary>
        Pin18 = 1 << 18,

        /// <summary>
        /// Pin 21 selected.
        /// </summary>
        Pin21 = 1 << 21,

        /// <summary>
        /// Pin 22 selected.
        /// </summary>
        Pin22 = 1 << 22,

        /// <summary>
        /// Pin 23 selected.
        /// </summary>
        Pin23 = 1 << 23,

        /// <summary>
        /// Pin 24 selected.
        /// </summary>
        Pin24 = 1 << 24,

        /// <summary>
        /// Pin 25 selected.
        /// </summary>
        Pin25 = 1 << 25,

        /// <summary>
        /// Pin 27 selected.
        /// </summary>
        Pin27 = 1 << 27,

        /// <summary>
        /// Pin 28 selected.
        /// </summary>
        Pin28 = 1 << 28,

        /// <summary>
        /// Pin 29 selected.
        /// </summary>
        Pin29 = 1 << 29,

        /// <summary>
        /// Pin 30 selected.
        /// </summary>
        Pin30 = 1 << 30,

        /// <summary>
        /// Pin 31 selected.
        /// </summary>
        Pin31 = (ulong)1 << 31,


        //added for CM3

        /// <summary>
        /// Pin 32 selected.
        /// </summary>
        Pin32 = (ulong)1 << 32,

        /// <summary>
        /// Pin 33 selected.
        /// </summary>
        Pin33 = (ulong)1 << 33,

        /// <summary>
        /// Pin 34 selected.
        /// </summary>
        Pin34 = (ulong)1 << 34,

        /// <summary>
        /// Pin 35 selected.
        /// </summary>
        Pin35 = (ulong)1 << 35,

        /// <summary>
        /// Pin 36 selected.
        /// </summary>
        Pin36 = (ulong)1 << 36,

        /// <summary>
        /// Pin 37 selected.
        /// </summary>
        Pin37 = (ulong)1 << 37,

        /// <summary>
        /// Pin 38 selected.
        /// </summary>
        Pin38 = (ulong)1 << 38,

        /// <summary>
        /// Pin 39 selected.
        /// </summary>
        Pin39 = (ulong)1 << 39,

        /// <summary>
        /// Pin 40 selected.
        /// </summary>
        Pin40 = (ulong)1 << 40,

        /// <summary>
        /// Pin 41 selected.
        /// </summary>
        Pin41 = (ulong)1 << 41,

        /// <summary>
        /// Pin 42 selected.
        /// </summary>
        Pin42 = (ulong)1 << 42,

        /// <summary>
        /// Pin 43 selected.
        /// </summary>
        Pin43 = (ulong)1 << 43,

        /// <summary>
        /// Pin 44 selected.
        /// </summary>
        Pin44 = (ulong)1 << 44,

        /// <summary>
        /// Pin 45 selected.
        /// </summary>
        Pin45 = (ulong)1 << 45,
    }
}
