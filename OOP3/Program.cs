using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ILoanManager consumerLoanManager = new ConsumerLoanManager();
            ILoanManager vehicleLoanManager = new VehicleLoanManager();
            ILoanManager mortgageLoanManager = new MortgageLoanManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Applicate(consumerLoanManager, databaseLoggerService);

            List<ILoanManager> loans = new List<ILoanManager>() {consumerLoanManager, vehicleLoanManager };

            //applicationManager.LoanInfo(loans);


        }
    }
}
