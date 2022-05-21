﻿using Anabasis.Graphics.Abstractions.Buffer;
using Anabasis.Platform.Abstractions;

namespace Anabasis.Graphics.Abstractions.Shaders;

public interface IShaderSupport
{
    ValueTask<IPlatformHandle> CompileAndLinkAsync(IShaderProgramTexts texts,
        CancellationToken cancellationToken = default);

    IVertexBufferFormatter<TVertex> CreateVertexFormatter<TVertex>(IPlatformHandle programHandle)
        where TVertex : unmanaged;

    IShaderParameter<TParam> CreateParameter<TParam>(string name, IPlatformHandle programHandle)
        where TParam : struct;

    void UseShaderProgram(IPlatformHandle program);
}