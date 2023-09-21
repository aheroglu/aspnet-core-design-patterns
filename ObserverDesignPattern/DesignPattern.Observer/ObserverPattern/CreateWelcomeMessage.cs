using DesignPattern.Observer.DAL;
using System;

namespace DesignPattern.Observer.ObserverPattern
{
    public class CreateWelcomeMessage : IObserver
    {
        private readonly IServiceProvider _serviceProvider;

        Context context = new Context();

        public CreateWelcomeMessage(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser user)
        {
            context.WelcomeMessages.Add(new WelcomeMessage
            {
                FullName = user.UserName,
                Content = "Dergi Bültenimize Kayıt Olduğunuz İçin Teşekkürler! Dergilerimize Websitemizden Ulaşabilirsiniz.",
            });

            context.SaveChanges();
        }
    }
}
