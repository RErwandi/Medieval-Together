﻿namespace EZ.ScriptableObjectArchitecture
{
    public interface IGameEventListener<T>
    {
        void OnEventRaised(T value);
    }
    public interface IGameEventListener
    {
        void OnEventRaised();
    } 
}