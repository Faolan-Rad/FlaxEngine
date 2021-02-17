// Copyright (c) 2012-2021 Wojciech Figat. All rights reserved.

using FlaxEngine;

namespace FlaxEditor.SceneGraph.Actors
{
    /// <summary>
    /// Actor node for <see cref="NavModifierVolume"/>.
    /// </summary>
    /// <seealso cref="BoxVolumeNode" />
    [HideInEditor]
    public sealed class NavModifierVolumeNode : BoxVolumeNode
    {
        /// <inheritdoc />
        public NavModifierVolumeNode(Actor actor)
        : base(actor)
        {
        }
    }
}
