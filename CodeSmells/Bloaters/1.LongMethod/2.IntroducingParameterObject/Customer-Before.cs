using System;

namespace CodeSmells.Bloaters.LongMethod.IntroducingParameterObject
{
    interface Customer
    {
        void IssueInvoiceForServices(DateTime startDate, DateTime endDate);
        void IssueOverdueNotification(DateTime startDate, DateTime endDate);
        void CollectPaymentForServices(DateTime startDate, DateTime endDate);
    }
}
