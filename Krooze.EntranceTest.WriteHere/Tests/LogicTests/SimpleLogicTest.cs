using Krooze.EntranceTest.WriteHere.Structure.Model;
using System.Collections.Generic;

namespace Krooze.EntranceTest.WriteHere.Tests.LogicTests
{
    public class SimpleLogicTest
    {
        public decimal? GetOtherTaxes(CruiseDTO cruise)
        {
            //TODO: Based on the CruisesDTO object, gets if there is some other tax that not the port charge

            return cruise.TotalValue - (cruise.PortCharge + cruise.CabinValue);

        }

        public bool? IsThereDiscount(CruiseDTO cruise)
        {
            //TODO: Based on the CruisesDTO object, check if the second passenger has some kind of discount, based on the first passenger price
            //Assume there are always 2 passengers on the list

            return cruise.PassengerCruise[0].Cruise.CabinValue > cruise.PassengerCruise[1].Cruise.CabinValue;

        }

        public int? GetInstallments(decimal fullPrice)
        {
            //TODO: Based on the full price, find the max number of installments
            // -The absolute max number is 12
            // -The minimum value of the installment is 200

            if (fullPrice > 0 && fullPrice.ToString() != string.Empty)
            {

                List<int> installments = new List<int>() { 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

                foreach (var item in installments)
                {
                    if (fullPrice / item >= 200)
                    {
                        return item;
                    }
                }
            }

            return 1;
        }
    }
}
