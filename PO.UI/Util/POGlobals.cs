﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonelOrganizer.Util
{
    public class POGlobals
    {
        // Kullanici Login islemi basarili ise, kullanicinin UserID degerini tum uygulama lifecycle da tasir.
        public static Guid UserID;
        public static string UserNameSurname;
        public static Guid ContactID;
        public static Guid EventID;
        public static Guid CreditCard;
        public static Guid AppointmentID;
        public static Guid CreditCardID;
        public static Guid IncomeID;
        public static Guid ExpenseID;
        public static Guid BudgetID;
        public static Guid InstallmentID;
    }
}
