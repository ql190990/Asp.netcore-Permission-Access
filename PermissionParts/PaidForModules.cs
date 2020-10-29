// Copyright (c) 2018 Jon P Smith, GitHub: JonPSmith, web: http://www.thereformedprogrammer.net/
// Licensed under MIT license. See License.txt in the project root for license information.

using System;

namespace PermissionParts
{
    /// <summary>
    /// This is an example of how you would manage what optional parts of your system a user can access
    /// NOTE: You can add Display attributes (as done on Permissions) to give more information about a module
    /// </summary>
    [Flags]
    public enum PaidForModules : long
    {
        None = 0,
        ADM = 1,
        AI = 2,
        BM = 3,
        CR = 4,
        ENG1 = 5,
        ENG2 = 6,
        LOG = 7,
        MF = 8,
        OS = 9,
        QC = 10,
        SCM1 = 11,
        SCM2 = 12,
        SE = 13,
        TRAINING = 14,
        ADMINISTRATOR = 15,
    }
}