using System.Drawing;
using Autofac;
using PaintLikeCore;

namespace WinFormsPaintLike
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<DrawingManager>().SingleInstance();
            builder.RegisterType<DrawingPointsArray>().WithParameter("size","2");
            builder.RegisterType<PaintLike>();
            builder.RegisterType<PenOptionsForm>().SingleInstance();

            return builder.Build();
        }
    }
}