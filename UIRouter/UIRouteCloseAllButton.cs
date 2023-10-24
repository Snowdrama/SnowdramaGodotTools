using Godot;
using System;

public partial class UIRouteCloseAllButton : Button
{
    [Export] UIRouter _router;
    public override void _Ready()
    {
        this.Connect(SignalName.Pressed, Callable.From(() => { _router.CloseAll(); }));
    }
}
