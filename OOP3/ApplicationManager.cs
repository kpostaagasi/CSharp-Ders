using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        //Method Injection
        public void Applicate(ILoanManager loanManager, ILoggerService loggerService)
        {

            //Basvuran Bilgilerini Degerlendirme

            loanManager.Calculate();
            loggerService.Log();

        }
        public void LoanInfo(List<ILoanManager> loans)
        {
            foreach (var loan in loans)
            {
                loan.Calculate();
            }
        }
    }
}
