using System.Globalization;

namespace Course.Entities {
    class CarRental {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Vehicle Vehicle { get; set; }
        public Invoice Invoice { get; set; }

        public CarRental(DateTime start, DateTime finish, Vehicle vehicle) {
            Start = start;
            Finish = finish;
            Vehicle = vehicle;
            Invoice = null;
        }

        public void GenerateInvoice(double pricePerHour, double pricePerDay) {
            TimeSpan duration = Finish.Subtract(Start);
            double basicPayment = 0.0;
            if (duration.TotalHours <= 12.0) {
                basicPayment = pricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else {
                basicPayment = pricePerDay * Math.Ceiling(duration.TotalDays);
            }
            double tax = basicPayment * 0.2;
            Invoice = new Invoice(basicPayment, tax);
        }
    }
}
