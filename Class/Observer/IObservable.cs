﻿namespace tarot{
    public interface IObservable<T>{
        public void AddObserver(IObserver<T> observer);
        public void NotifyObservers(T value);
    }
}