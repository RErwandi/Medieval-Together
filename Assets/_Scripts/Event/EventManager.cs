using System;
using System.Collections.Generic;
using UnityEngine;

namespace Reynold.Event
{
    /// <summary>
    /// GameEvent are used throughout the game for general game events (game started, game ended, life lost, etc.)
    /// </summary>
    public struct GameEvent
    {
        public string eventName;
        public GameEvent(string eventName)
        {
            this.eventName = eventName;
        }
    
        private static GameEvent e;
    
        public static void Trigger(string eventName)
        {
            e.eventName = eventName;
            EventManager.TriggerEvent(e);
        }
    }
    
    /// <summary>
    /// This class handle event management, and can be used to broadcast events throughout the game, to tell one or many class that something's happened.
    /// Events are struct, you can define any kind of events you want. This manager comes with GameEvents, which are
    /// basically just made of a string, but you can work with more complex ones if you want.
    ///
    /// To trigger a new event, from anywhere, do YOUR_EVENT.Trigger(YOUR_PARAMETERS)
    /// So GameEvent.Trigger("Save"); for example will trigger a Save GameEvent
    /// 
    /// you can also call EventManager.TriggerEvent(YOUR_EVENT);
    /// For example : EventManager.TriggerEvent(new GameEvent("GameStart")); will broadcast an GameEvent named GameStart to all listeners.
    ///
    /// To start listening to an event from any class, there are 3 things you must do : 
    ///
    /// 1 - tell that your class implements the EventListener interface for that kind of event.
    /// For example: public class GUIManager : Singleton<GUIManager>, EventListener<GameEvent>
    /// You can have more than one of these (one per event type).
    ///
    /// 2 - On Enable and Disable, respectively start and stop listening to the event :
    /// void OnEnable()
    /// {
    /// 	this.EventStartListening<GameEvent>();
    /// }
    /// void OnDisable()
    /// {
    /// 	this.EventStopListening<GameEvent>();
    /// }
    /// 
    /// 3 - Implement the MMEventListener interface for that event. For example :
    /// public void OnEvent(GameEvent gameEvent)
    /// {
    /// 	if (gameEvent.eventName == "GameOver")
    ///		{
    ///			// DO SOMETHING
    ///		}
    /// } 
    /// will catch all events of type MMGameEvent emitted from anywhere in the game, and do something if it's named GameOver 
    /// </summary>
    public static class EventManager
    {
        private static Dictionary<Type, List<IEventListenerBase>> _subscribersList;

        static EventManager()
        {
            _subscribersList = new Dictionary<Type, List<IEventListenerBase>>();
        }
        
        /// <summary>
        /// Adds a new subscriber to a certain event.
        /// </summary>
        /// <param name="listener">listener.</param>
        /// <typeparam name="TEvent">the event type.</typeparam>
        public static void AddListener<TEvent>(IEventListener<TEvent> listener) where TEvent : struct
        {
            var eventType = typeof(TEvent);

            if(!_subscribersList.ContainsKey(eventType))
                _subscribersList[eventType] = new List<IEventListenerBase>();

            if( !SubscriptionExists(eventType, listener))
                _subscribersList[eventType].Add(listener);
        }
        
        /// <summary>
        /// Removes a subscriber from a certain event.
        /// </summary>
        /// <param name="listener">listener.</param>
        /// <typeparam name="TEvent">the event type.</typeparam>
        public static void RemoveListener<TEvent>(IEventListener<TEvent> listener) where TEvent : struct
        {
            var eventType = typeof(TEvent);
            List<IEventListenerBase> subscriberList = _subscribersList[eventType];

            for (int i = 0; i < subscriberList.Count; i++)
            {
                if(subscriberList[i] == listener)
                {
                    subscriberList.Remove(subscriberList[i]);

                    if( subscriberList.Count == 0 )
                        _subscribersList.Remove( eventType );

                    return;
                }
            }
        }
        
        /// <summary>
        /// Triggers an event. All instances that are subscribed to it will receive it (and will potentially act on it).
        /// </summary>
        /// <param name="newEvent">the event to trigger.</param>
        /// <typeparam name="TEvent">the 1st type parameter.</typeparam>
        public static void TriggerEvent<TEvent>(TEvent newEvent) where TEvent : struct
        {
            List<IEventListenerBase> list;
            if(!_subscribersList.TryGetValue(typeof(TEvent), out list))
                return;

            for (int i=0; i<list.Count; i++)
            {
                (list[i] as IEventListener<TEvent>).OnEvent(newEvent);
            }
        }
        
        /// <summary>
        /// Checks if there are subscribers for a certain type of events
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="receiver">receiver.</param>
        /// <returns><c>true</c>, if exists was subscribed, <c>false</c> otherwise.</returns>
        private static bool SubscriptionExists( Type type, IEventListenerBase receiver )
        {
            List<IEventListenerBase> receivers;

            if(!_subscribersList.TryGetValue( type, out receivers)) return false;

            bool exists = false;

            for (int i=0; i<receivers.Count; i++)
            {
                if(receivers[i] == receiver)
                {
                    exists = true;
                    break;
                }
            }

            return exists;
        }
    }
    
    /// <summary>
    /// Static class that allows any class to start or stop listening to events
    /// </summary>
    public static class EventRegister
    {
        public delegate void Delegate<T>(T eventType);

        public static void EventStartListening<EventType>( this IEventListener<EventType> caller ) where EventType : struct
        {
            EventManager.AddListener<EventType>( caller );
        }

        public static void EventStopListening<EventType>( this IEventListener<EventType> caller ) where EventType : struct
        {
            EventManager.RemoveListener<EventType>( caller );
        }
    }
    
    /// <summary>
    /// Event listener basic interface
    /// </summary>
    public interface IEventListenerBase { };
    
    /// <summary>
    /// A public interface you'll need to implement for each type of event you want to listen to.
    /// </summary>
    /// <typeparam name="T">Type of Event.</typeparam>
    public interface IEventListener<T> : IEventListenerBase
    {
        void OnEvent(T eventType);
    }
}