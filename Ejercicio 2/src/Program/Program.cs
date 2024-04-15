using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de la cita
            Appointment appointment1 = new Appointment("Juan Perex", "55782569", "5555-555-555", DateTime.Now, "Wall Street", "Armand");

            // Crear una instancia del servicio de citas y programar la cita
            string appointmentResult1 = AppointmentService.CreateAppointment(appointment1);
            Console.WriteLine(appointmentResult1);

            // Crear otra instancia de la cita
            Appointment appointment2 = new Appointment("Ralf Manson", "", "5555-555-555", DateTime.Now, "Queen Street", "");

            // Programar la segunda cita
            string appointmentResult2 = AppointmentService.CreateAppointment(appointment2);
            Console.WriteLine(appointmentResult2);
        }
    }
}
