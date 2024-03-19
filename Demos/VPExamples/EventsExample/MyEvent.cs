using System;

namespace EventsExample
{
    // Объявим тип делегата для обработчика событий
    public delegate void MyEventHandler();
    public class MyEvent
    {
        // Объявляем событие
        public event MyEventHandler OnSomeEvent;

        // Этот метод вызывается для запуска события
        public virtual void SomeEvent()
        {
            // Если событие не пустое
            //if (OnSomeEvent != null)
            //    // Вызывается обработчик(и) с помощью делегата
            //    OnSomeEvent();
            OnSomeEvent?.Invoke();
        }


    }
}
