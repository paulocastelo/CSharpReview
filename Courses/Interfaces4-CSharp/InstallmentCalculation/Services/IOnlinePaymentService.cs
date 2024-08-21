using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallmentCalculation.Services {
    interface IOnlinePaymentService {
        double PaymentFee(double amount); //Taxas de pagamento
        double Interest(double amount, int months); //Juros
    }
}
