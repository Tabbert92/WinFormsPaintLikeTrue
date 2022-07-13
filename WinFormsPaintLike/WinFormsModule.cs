using Autofac;

namespace WinFormsPaintLike
{
    public class WinFormsModule : Autofac.Module
    {
        protected override void Load (ContainerBuilder builder)
        {
            builder.RegisterType<PaintLike>();
            builder.RegisterType<PenOptionsForm>().SingleInstance();
            base.Load(builder);
        }
    }
}