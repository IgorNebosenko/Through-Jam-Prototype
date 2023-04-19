using ElectrumGames.Core.Configs;
using ElectrumGames.Core.Vehicle;
using Zenject;

namespace ElectrumGames.Injection
{
    public class ProjectInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<InputSchema>().WhenInjectedInto<VehicleController>();
        }
    }
}