using Autofac;

namespace PaintLikeCore
{
    public class CoreModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DrawingManager>().SingleInstance();
            base.Load(builder);
        }
    }
}
