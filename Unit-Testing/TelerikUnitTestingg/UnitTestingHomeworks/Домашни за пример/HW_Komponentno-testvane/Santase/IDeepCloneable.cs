﻿namespace Santase
{
    public interface IDeepCloneable<out T>
    {
        T DeepClone();
    }

}
