using Assets._4._Study._02._Script.Study.Pattern.Decorator.Attack;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets._4._Study._02._Script.Study.Pattern.Service_Locator
{
    public class ServiceLocator : MonoBehaviour
    {
        private Dictionary<Type, object> services = new Dictionary<Type, object>();

        public T GetService<T>() where T : class
        {
            if (services.TryGetValue(typeof(T), out var service))
            {
                return (T)service;
            }

            return null;
        }


        public void RegisterService<T>(T service)
        {
            services[typeof(T)] = service;
        }

        public void UnregisterService<T>()
        {
            services.Remove(typeof(T));
        }

        
    }
}