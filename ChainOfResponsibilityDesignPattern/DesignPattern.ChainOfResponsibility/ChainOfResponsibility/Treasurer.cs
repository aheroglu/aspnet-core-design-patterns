using DesignPattern.ChainOfResponsibility.DataAccess;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class Treasurer : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel request)
        {
            Context context = new Context();

            if (request.Amount <= 100)
            {
                CustomerProcess customerProcess = new CustomerProcess();

                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.EmployeeName = "Veznedar - Ayşe Çınar";
                customerProcess.Description = "Para Çekme İşlemi Onaylandı, Müşteriye Talep Ettiği Tutar Ödendi.";

                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }

            else if (NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();

                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.EmployeeName = "Veznedar - Ayşe Çınar";
                customerProcess.Description = "Para Çekme Tutarı Veznedarın Günlük Ödeyebileceği Limiti Aştığı İçin İşlem Şube Müdür Yardımcısına Yönlendirildi.";

                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();

                NextApprover.ProcessRequest(request);
            }
        }
    }
}
