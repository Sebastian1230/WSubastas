using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WSubastas
{
    internal class clsSubasta
    {
         public string Producto {  get; set; }
         public double PrecioInicial { get; set; }
         public int Duracion { get; set; }
         public string Reglas  { get; set; }


         public clsSubasta(string producto, double precioinicial, int duracion, string reglas)
         { 
             this.Producto = producto;
             this.PrecioInicial = precioinicial;
             this.Duracion = duracion;
             this.Reglas = reglas;

         }

        /*public string Producto { get; set; }
        public double PrecioInicial { get; set; }
        public int Duracion { get; set; }
        public string Reglas { get; set; }

        private Timer countdownTimer {  get; set; }
        private DateTime endTime;

        public clsSubasta(string producto, double precioinicial, Timer countdowntimer, string reglas)
        {
            this.Producto = producto;
            this.PrecioInicial = precioinicial;
            this.countdownTimer = countdowntimer;
            this.Reglas = reglas;

            // Configura el Timer para la cuenta regresiva
            countdownTimer = new Timer(1000); // Actualiza cada segundo
            countdownTimer.Elapsed += CountdownTimer_Elapsed;
            countdownTimer.AutoReset = true;

            // Establece el tiempo final (cuando finaliza la cuenta regresiva)
            endTime = DateTime.Now.AddMinutes(Duracion);
        }

        public void StartCountdown()
        {
            countdownTimer.Start();
        }

        private void CountdownTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            // Calcula el tiempo restante
            TimeSpan remainingTime = endTime - DateTime.Now;

            // Detén el Timer cuando se agote el tiempo
            if (remainingTime <= TimeSpan.Zero)
            {
                countdownTimer.Stop();
                // Puedes realizar otras acciones aquí cuando finalice la cuenta regresiva

            }
        }*/
        /*public string Producto { get; set; }
        public double PrecioInicial { get; set; }
        public int Duracion { get; set; }
        public string Reglas { get; set; }

        private Timer countdownTimer;
        private DateTime endTime;

        public clsSubasta(string producto, double precioinicial, int duracion, string reglas)
        {
            this.Producto = producto;
            this.PrecioInicial = precioinicial;
            this.Duracion = duracion;
            this.Reglas = reglas;

            // Configura el Timer para la cuenta regresiva
            countdownTimer = new Timer(1000); // Actualiza cada segundo
            countdownTimer.Elapsed += CountdownTimer_Elapsed;
            countdownTimer.AutoReset = true;

            // Establece el tiempo final (cuando finaliza la cuenta regresiva)
            endTime = DateTime.Now.AddMinutes(Duracion);
        }

        public void StartCountdown()
        {
            countdownTimer.Start();
        }

        private void CountdownTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            // Calcula el tiempo restante
            TimeSpan remainingTime = endTime - DateTime.Now;

            // Detén el Timer cuando se agote el tiempo
            if (remainingTime <= TimeSpan.Zero)
            {
                countdownTimer.Stop();
                // Puedes realizar otras acciones aquí cuando finalice la cuenta regresiva
                Console.WriteLine($"La subasta para el producto '{Producto}' ha finalizado.");
            }
        }*/
    }
}



