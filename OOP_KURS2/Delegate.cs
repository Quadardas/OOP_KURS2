using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_KURS2
{
    public delegate void Display();
    public class Delegate : IDisposable
    {
        private System.ComponentModel.Component components = new System.ComponentModel.Component();
        bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    components.Dispose();
                }
                disposed = true;
            }
        }

        string avava;

        Display display;

        public void OnPlanetAdded()
        {

            avava = ("Врач добавлен (демонстрация делегатов)");
        }
        public string Displayed(Object obj)
        {
            string ava = obj.GetType().ToString();
            switch (ava)
            {
                case "OOP_KURS2.Doctor":
                    display += OnPlanetAdded;
                    break;

            }
            display();
            return avava;
        }
    }
}
