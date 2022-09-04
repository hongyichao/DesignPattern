﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Subject 
    {
        private List<IObserver> observers = new List<IObserver>();

        public void AddObserver(IObserver observer) 
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer) 
        { 
            observers.Remove(observer);
        }

        public void NotifyObservers() 
        {
            foreach (IObserver observer in observers) 
            {
                observer.NotifyUpdate();
            }
        }
    }
}
