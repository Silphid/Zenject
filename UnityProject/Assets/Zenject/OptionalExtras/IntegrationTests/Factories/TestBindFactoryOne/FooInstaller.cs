using System;
using Zenject;

namespace Zenject.Tests.TestBindFactoryOne
{
    public class FooInstaller : MonoInstaller
    {
        string _param1;

        [Inject]
        public void Init(string param1)
        {
            _param1 = param1;
        }

        public override void InstallBindings()
        {
            // Allow passing null for validation to work
            Container.BindInstance(_param1, true).WhenInjectedInto<Foo>();

            Container.Bind<Foo>().FromGameObject();
        }
    }
}
