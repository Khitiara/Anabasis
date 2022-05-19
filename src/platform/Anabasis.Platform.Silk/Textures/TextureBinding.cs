﻿using Anabasis.Graphics.Abstractions.Textures;
using Anabasis.Platform.Abstractions;
using Silk.NET.OpenGL;

namespace Anabasis.Platform.Silk.Textures;

public readonly record struct TextureBinding(int Unit, TextureHandle Handle) : ITextureBinding
{
    IPlatformHandle ITextureBinding.TextureHandle => Handle;
}