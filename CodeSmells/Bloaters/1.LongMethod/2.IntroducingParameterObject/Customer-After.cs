using System;


namespace CodeSmells.Bloaters.LongMethod.IntroducingParameterObject
{
    interface Customer2
    {
        void IssueInvoiceForServices(ServiceDateRange dateRange);
        void IssueOverdueNotification(ServiceDateRange dateRange);
        void CollectPaymentForServices(ServiceDateRange dateRange);
    }


    public class ServiceDateRange
    {
        DateTime StartDate { set; get; }
        DateTime EndDate { set; get; }

        //validation rules...
    }
}
