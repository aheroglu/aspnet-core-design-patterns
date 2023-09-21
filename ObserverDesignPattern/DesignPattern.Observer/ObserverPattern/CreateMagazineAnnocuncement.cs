using DesignPattern.Observer.DAL;
using System;

namespace DesignPattern.Observer.ObserverPattern
{
    public class CreateMagazineAnnocuncement : IObserver
    {
        private readonly IServiceProvider _serviceProvider;

        Context context = new Context();

        public CreateMagazineAnnocuncement(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser user)
        {
            context.UserProcesses.Add(new UserProcess
            {
                FullName = user.UserName,
                Magazine = "Bilim Dergisi",
                Content = "Bilim Dergimiz Mart Sayısı 1 Mart Tarihinde Evinize Ulaştırılacaktır. Konular Jüpiter ve Mars Gezegenleri Olacaktır."
            });

            context.SaveChanges();
        }
    }
}
