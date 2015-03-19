﻿# region Includes

using System;

# endregion

namespace RobX.Communication
{
    # region Event Handler Delegates

    /// <summary>
    /// Event handler delegate for communication (network or serial port) events.
    /// </summary>
    /// <param name="sender">Current instance of a communication class.</param>
    /// <param name="e">Event argument that contains the data.</param>
    public delegate void CommunicationEventHandler(object sender, CommunicationEventArgs e);

    /// <summary>
    /// Event handler delegate for communication status change events (StatusChanged).
    /// </summary>
    /// <param name="sender">Current instance of a communication class.</param>
    /// <param name="e">Event argument that contains the new status change.</param>
    public delegate void CommunicationStatusEventHandler(object sender, CommunicationStatusEventArgs e);

    # endregion

    # region Event Arguments

    /// <summary>
    /// Event argument for communication class that can contain data.
    /// </summary>
    public class CommunicationEventArgs : EventArgs
    {
        private byte[] mData;

        /// <summary>
        /// Constructor for CommunicationEventArgs event argument class.
        /// </summary>
        /// <param name="data">Data that has been or is being received/sent.</param>
        public CommunicationEventArgs(byte[] data)
        {
            Data = data;
        }

        /// <summary>
        /// Data that has been or is being received/sent.
        /// </summary>
        public byte[] Data
        {
            get { return mData; }
            set
            {
                if (value == null || value.Length == 0)
                    mData = null;
                else
                {
                    mData = new byte[value.Length];
                    Array.Copy(value, mData, value.Length);
                }
            }
        }
    }

    /// <summary>
    /// Event argument for communication class that can contain a new status change.
    /// </summary>
    public class CommunicationStatusEventArgs : EventArgs
    {
        private string mStatus = "";

        /// <summary>
        /// String indicating the change of status.
        /// </summary>
        public string Status { get { return mStatus; } }

        /// <summary>
        /// Constructor for CommunicationStatusEventArgs event argument class.
        /// </summary>
        /// <param name="status">String indicating the change of status.</param>
        public CommunicationStatusEventArgs(string status)
        {
            mStatus = status;
        }
    }

    # endregion
}
