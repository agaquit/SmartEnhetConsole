using AdvancedDevice.Services;

var device = new DeviceManager("HostName=kyhstockholm-iothub.azure-devices.net;DeviceId=advanced_device;SharedAccessKey=uHrrOfZTG2eGAEHxXz6eljazdtFYgXTMpAIoTDj8miY=");
device.Start();

Console.WriteLine("Press [Enter] to close application");
Console.ReadLine();