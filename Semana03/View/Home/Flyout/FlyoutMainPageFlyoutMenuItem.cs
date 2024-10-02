using System;

namespace Semana03.View.Home.Flyout
{
    public class FlyoutMainPageFlyoutMenuItem
    {
        public FlyoutMainPageFlyoutMenuItem()
        {
            TargetType = typeof(FlyoutMainPageFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public Type TargetType { get; set; }
    }
}