using System;

namespace _Source
{
    public static class EventSystem
    {
        public static event Action<float> OnAddingCoins;
        public static event Action OnRestart;

        public static void InvokeAdding(float count) => OnAddingCoins.Invoke(count);
        public static void InvokeRestart() => OnRestart.Invoke();
    }
}