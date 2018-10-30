﻿// Copyright © Pixel Crushers. All rights reserved.

using UnityEngine;

namespace PixelCrushers.Wrappers
{

    /// <summary>
    /// This wrapper for PixelCrushers.DataSynchronizer keeps references intact if you
    /// switch between the compiled assembly and source code versions of the original
    /// class.
    /// </summary>
    [AddComponentMenu("Pixel Crushers/Common/Message System/Data Synchronizer")]
    public class DataSynchronizer : PixelCrushers.DataSynchronizer
    {
    }

}
