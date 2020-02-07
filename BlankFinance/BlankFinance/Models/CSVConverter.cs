using Microsoft.AspNetCore.Http;
using System;
using System.Collections.ObjectModel;
using System.IO;

namespace BlankFinance.Models
{
    public class CSVConverter
    {
        public Collection<Transaction> BankOfAmerica(IFormFile file)
        {
            Collection<Transaction> transactions = new Collection<Transaction>();
            Collection<Type> types = new Collection<Type>();
            Collection<Category> categories = new Collection<Category>(); 
            return transactions;
        }

        public Collection<Transaction> DesktopTransactions(IFormFile file)
        {
            Collection<Transaction> transactions = new Collection<Transaction>();

            string line;
            using (var streamReader = new StreamReader(file.OpenReadStream()))
            {
                while ((line = streamReader.ReadLine()) != null && !string.IsNullOrWhiteSpace(line))
                {
                    string[] split = line.Split(',');

                    Transaction temp = new Transaction()
                    {
                        Date = DateTime.Parse(split[0]),
                        Type = split[1],
                        Description = split[2],
                        Amount = Decimal.Parse(split[3]),
                        Category = split[4]
                    };
                    transactions.Add(temp);
                }
            }
               
            return transactions; 
        } 

        public Collection<Transaction> BetterBankingAndTrust(IFormFile file)
        {
            Collection<Transaction> transactions = new Collection<Transaction>();
            string amount = null;
            string[] split = { "", "" }; //line.Split(',');
            if (split[4].Replace("$", "").Contains("("))
            {
                amount = split[4].Replace("(", "-").Replace(")", "");

            }

            Transaction temp = new Transaction()
            {
                Date = DateTime.Parse(split[0]),
                Type = split[1] + "BBT",
                Description = split[3],
                Amount = (amount == null) ? Decimal.Parse(split[4].Replace("$", "")) : (Convert.ToDecimal(amount.Replace("$", ""))),
                Category = Categorize(split[3])
            };
            amount = null;

            return transactions;
        }

        public Collection<Transaction> Chase(IFormFile file)
        {
            Collection<Transaction> transactions = new Collection<Transaction>();

            string[] split = { "", "" }; //line.Split(',');
            Transaction temp = new Transaction()
            {
                Date = DateTime.Parse(split[1]),
                Type = split[0] + " CH",
                Description = split[3],
                Amount = Convert.ToDecimal(split[4]),
                Category = Categorize(split[3])
            };

            transactions.Add(temp);

            return transactions;
        }

        public Collection<Transaction> AmericanExpress(IFormFile file)
        {
            Collection<Transaction> transactions = new Collection<Transaction>();
            string[] split = { "", "" }; //line.Split(',');
            Transaction temp = new Transaction()
            {
                Date = DateTime.Parse(split[0]),
                Type = "Credit AE",
                Description = split[2],
                Amount = Convert.ToDecimal(split[8]) * -1,
                Category = Categorize(split[2])
            };

            transactions.Add(temp);

            return transactions;
        }

        public string Categorize(string description)
        {
            string category = string.Empty;

            //if (description.Contains("Harris Teeter") || description.Contains("HARRIS TEETER") || description.Contains("FOOD LION") || description.Contains("3501 HWY 601") || description.Contains("4226 HWY 49") || description.Contains("WAL-MART") || description.Contains("WAL-SAMS") || description.Contains("ALDI") || description.Contains("WM SUPERCENTER"))
            //{
            //    category = ConstVariables.GROCERIES;
            //}
            //else if (description.Contains("AMAZON MKTPLACE") || description.Contains("Amazon.com") || description.Contains("AMAZON.COM") || description.Contains("AMAZON VIDEO") || description.Contains("BATH & BODY WORKS") || description.Contains("Amazon Services-Ki") || description.Contains("TARGET") || description.Contains("Amazon Video") || description.Contains("LULAROE") || description.Contains("SHUTTERFLY") || description.Contains("Etsy.com") || description.Contains("WALMART.COM"))
            //{
            //    category = ConstVariables.SHOPPING;
            //}
            //else if (description.Contains("STDNT LOAN") || description.Contains("STUDENT LN"))
            //{         xxxsssss
            //    category = ConstVariables.SL;
            //}
            //else if (description.Contains("PETCO") || description.Contains("PETSMART"))
            //{
            //    category = ConstVariables.PET;
            //}
            //else if (description.Contains("HULU"))
            //{
            //    category = ConstVariables.HULU;
            //}
            //else if (description.Contains("NOVANT") || description.Contains("CHS"))
            //{
            //    category = ConstVariables.DOCTOR;
            //}
            //else if (description.Contains("MEINEKE") || description.Contains("AUTOBELL"))
            //{
            //    category = ConstVariables.CAR_MAINTENANCE;
            //}
            //else if (description.Contains("BRITTANY ACH CREDIT") || description.Contains("PAYROLL CABARRUS"))
            //{
            //    category = ConstVariables.CHECK;
            //}
            //else if (description.Contains("BBT DEALS"))
            //{
            //    category = ConstVariables.CREDIT;
            //}
            //else if (description.Contains("TEACHERSPAYTEACHERS") || description.Contains("AC MOORE") || description.Contains("TEACHERSPAYTEACHER"))
            //{
            //    category = ConstVariables.BRITTANY_WORK;
            //}
            //else if (description.Contains("ULTA") || description.Contains("GREAT CLIPS") || description.Contains("MODISH NAIL SPA") || description.Contains("LEFLER HAIR"))
            //{
            //    category = ConstVariables.BEAUTY;
            //}
            //else if (description.Contains("CITY OF CONCORD"))
            //{
            //    category = ConstVariables.WATER;
            //}
            //else if (description.Contains("UNION POWER"))
            //{
            //    category = ConstVariables.UNION_POWER;
            //}
            //else if (description.Contains("SERVISOLUTIONS") || description.Contains("PAYMENTS ALABAMA HOUSING"))
            //{
            //    category = ConstVariables.MORTGAGE;
            //}
            //else if (description.Contains("TIME WARNER"))
            //{
            //    category = ConstVariables.INTERNET;
            //}
            //else if (description.Contains("MAINTENANCE FEE") || description.Contains("MISCELLANEOUS"))
            //{
            //    category = ConstVariables.BANK_FEE;
            //}
            //else if (description.Contains("NATIONAL GENERAL"))
            //{
            //    category = ConstVariables.CAR_INSURANCE;
            //}
            //else if (description.Contains("REPUBLIC SERVICES"))
            //{
            //    category = ConstVariables.REPUBLIC_SERVICES;
            //}
            //else if (description.Contains("LOWES"))
            //{
            //    category = ConstVariables.LOWES_CREDIT_CARD;
            //}
            //else if (description.Contains("KHOLS.COM") || description.Contains("CHG PYMT KOHL'S"))
            //{
            //    category = ConstVariables.KHOLS;
            //}
            //else if (description.Contains("EPAY MOBIL CHASE"))
            //{
            //    category = ConstVariables.CHASE_PAYMENT;
            //}
            //else if (description.Contains("USA*CANTEEN") || description.Contains("STARBUCKS"))
            //{
            //    category = ConstVariables.SNACKS;
            //}
            //else if (description.Contains("CIRCLE K") || description.Contains("SHELL OIL") || description.Contains("SPEEDWAY") || description.Contains("KINGS QUICK STOP") || description.Contains("BP#9819517EARPS") || description.Contains("BP#2321925CAROLINA") || description.Contains("QT 1025") || description.Contains("QT 1030") || description.Contains("QT 1031") || description.Contains("KINGS CITGO QUICK STOP"))
            //{
            //    category = ConstVariables.GAS;
            //}
            //else if (description.Contains("BOJANGLES") || description.Contains("PEI WEI") || description.Contains("TACO BELL") || description.Contains("MCDONALD'S") || description.Contains("PIZZA HUT") || description.Contains("CHICK-FIL-A") || description.Contains("THE PIZZA LOFT") || description.Contains("LONGHORN STEAK") || description.Contains("MAMA RICOTTA'S") || description.Contains("DUNKIN") || description.Contains("5GUYS") || description.Contains("OCHARLEYS301CONCORD") || description.Contains("QDOBA MEXICAN") || description.Contains("PANERA BREAD") || description.Contains("MOE'S") || description.Contains("MCALISTERS DELI") || description.Contains("JIMMY JOHNS") || description.Contains("FIREBIRDS STONECR") || description.Contains("CRACKER BARREL") || description.Contains("OLIVE GARDEN") || description.Contains("HARDEE'S") || description.Contains("RED LOBSTER") || description.Contains("CHEESECAKE CHARLOTTE") || description.Contains("TSUNAMI STEAKHOUSE") || description.Contains("STICKY FINGERS") || description.Contains("HAWTHORNES") || description.Contains("JERSEY MIKE'S") || description.Contains("ZAXBY'S") || description.Contains("SUBWAY") || description.Contains("MAGGIANOS CHARLOTT") || description.Contains("GIGI`S CUPCAKES") || description.Contains("EAST COAST WINGS") || description.Contains("AFTON TAVERN") || description.Contains("TERRACE CAFE OF BALLANTY") || description.Contains("ROCK BOTTOM CHARLOTTE") || description.Contains("BUFFALO WILD WINGS") || description.Contains("FOODSBY") || description.Contains("BEN AND JERRY'S") || description.Contains("MARBLE SLAB CMRY") || description.Contains("BRIXX PIZZA") || description.Contains("PF CHANGS") || description.Contains("MIDWOOD SMOKEHOUSE") || description.Contains("FAMOUS TOASTERY") || description.Contains("DOMINO'S") || description.Contains("HILTON THE BAKERY") || description.Contains("TEXAS RDHSE") || description.Contains("BRUSTERS ICE CREAM") || description.Contains("SHOWMARS") || description.Contains("OUTBACK") || description.Contains("RED ROBIN") || description.Contains("SIERRA NEVADA TAPRESTNC") || description.Contains("GALS KITCHEN") || description.Contains("BAD DADDY'S BURGER BAR") || description.Contains("BURGER KING") || description.Contains("HARRISBURG FAMILY") || description.Contains("SMOKE PIT") || description.Contains("MELLOW MUSHROOM"))
            //{
            //    category = ConstVariables.DINNING_OUT;
            //}
            //else if (description.Contains("BB&T ONLINE TRANSFER") || description.Contains("OVERDRAFT TRANSFER"))
            //{
            //    category = ConstVariables.TRANSFER;
            //}
            //else if (description.Contains("HOA CONDO PAYME"))
            //{
            //    category = ConstVariables.HOA;
            //}
            //else if (description.Contains("REDBOX") || description.Contains("REGAL"))
            //{
            //    category = ConstVariables.ENTERTAINMENT;
            //}
            //else if (description.Contains("IKEA CHARLOTTE"))
            //{
            //    category = ConstVariables.HOME_ADDITIONS;
            //}
            //else if (description.Contains("IMPACT"))
            //{
            //    category = ConstVariables.IMPACT;
            //}
            return category;

        }
    }
}
