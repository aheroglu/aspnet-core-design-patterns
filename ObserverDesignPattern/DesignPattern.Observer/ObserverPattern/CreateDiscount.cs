using DesignPattern.Observer.DAL;
using System;

namespace DesignPattern.Observer.ObserverPattern
{
    public class CreateDiscount : IObserver
    {
        private readonly IServiceProvider _serviceProvider;

        Context context = new Context();

        public CreateDiscount(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser user)
        {
            context.Discounts.Add(new Discount
            {
                Code = "DERGIMART",
                Amount = 35,
                Status = true
            });

            context.SaveChanges();
        }
    }
}
