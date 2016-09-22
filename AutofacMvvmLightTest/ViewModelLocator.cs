using Autofac;

namespace AutofacMvvmLightTest
{
    public class ViewModelLocator
    {
        public static IContainer Container { get; private set; }

        public ViewModelLocator()
        {
            var builder = new ContainerBuilder();
            Container = builder.Build();
        }
    }
}