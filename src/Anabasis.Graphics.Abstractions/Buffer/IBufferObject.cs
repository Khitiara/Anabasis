﻿using Anabasis.Platform.Abstractions.Resources;

namespace Anabasis.Graphics.Abstractions.Buffer;

public interface IBufferObject<T> : IPlatformResource
    where T : unmanaged
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="data"></param>
    /// <param name="offset"></param>
    /// <remarks>
    /// This call *may* change the actively bound buffer object(s) if necessary for the particular backend graphics api
    /// </remarks>
    void LoadData(ReadOnlySpan<T> data, int offset = 0);

    /// <summary>
    /// Returns -1 if the buffer is not allocated
    /// </summary>
    int Length { get; }
    void Allocate(int length, ReadOnlySpan<T> data = default, BufferAccess flags = BufferAccess.None);
}