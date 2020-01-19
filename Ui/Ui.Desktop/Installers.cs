using Castle.MicroKernel.Registration;
using tomaszbaginski.UbsTask2.Logic.Ui;
using tomaszbaginski.UbsTask2.Logic.Ui.Models;
using tomaszbaginski.UbsTask2.Ui.Desktop;

public class Installers : IWindsorInstaller
{

    public void Install(Castle.Windsor.IWindsorContainer container,
        Castle.MicroKernel.SubSystems.Configuration.IConfigurationStore store)
    {

        ////rejestracja próśb
        //container.Register(
        //    // gdy zapytam o ILabel
        //    Component.For<ILabel>().
        //    //to mam dać ci to
        //    ImplementedBy<Label>());

        container.Register(Component.For<IFund>()
            .ImplementedBy<Fund>());

        container.Register(Component.For<IMainViewModel>()
            .ImplementedBy<MainViewModel>());

        container.Register(Component.For<IRelationViewModel>().
            ImplementedBy<RelationViewModel>());

        container.Register(Component.For<IShell>()
            .ImplementedBy<Shell>());

        container.Register(Component.For<MainWindow>().LifestyleTransient());
    }

}