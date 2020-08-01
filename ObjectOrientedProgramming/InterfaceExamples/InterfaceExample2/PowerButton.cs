namespace Interfaces2
{
    class PowerButton : ICommand
    {
        IElectronicDevice Device;
        public PowerButton(IElectronicDevice device)
        {
            this.Device = device;
        }
        public void Execute()
        {
            Device.On();
        }
        public void Undo()
        {
            Device.Off();
        }
    }
}
