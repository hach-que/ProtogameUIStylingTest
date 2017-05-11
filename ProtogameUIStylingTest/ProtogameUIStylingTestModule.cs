using System;
using Protogame;
using Protoinject;

namespace ProtogameUIStylingTest
{
    public class ProtogameUIStylingTestModule : IProtoinjectModule
    {
        public void Load(IKernel kernel)
        {
            kernel.Bind<IEntityFactory>().ToFactory();

            kernel.Bind<IBasicSkin>().To<DefaultBasicSkin>().InSingletonScope();
            kernel.Rebind<ISkinRenderer<Button>>().To<NuiButtonSkinRenderer>().InSingletonScope();
            kernel.Rebind<ISkinRenderer<CheckBox>>().To<NuiCheckBoxSkinRenderer>().InSingletonScope();
            kernel.Rebind<ISkinRenderer<Canvas>>().To<NuiCanvasSkinRenderer>().InSingletonScope();
            kernel.Rebind<ISkinRenderer<Label>>().To<NuiLabelSkinRenderer>().InSingletonScope();
        }
    }
}
