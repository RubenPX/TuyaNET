# TuyaNET

TuyaNET is a .NET library designed to interact with the Tuya API.

## Features

- Connect to the Tuya API

## Installation

To install the library, you can use NuGet Package Manager:

```bash
Install-Package PXByte.TuyaNET.API
```

## Usage

Here is a basic example of how to use TuyaNET to connect to the Tuya API and manage your devices:

```csharp
using TuyaNET;

class Program
{
    static void Main(string[] args)
    {
        var api = new TuyaApi("your-client-id", "your-client-secret");

        // Retrieve a list of devices
        var devices = api.GetDevices();

        foreach (var device in devices)
        {
            Console.WriteLine($"Device ID: {device.Id}, Name: {device.Name}");
        }

        // Control a device
        var deviceId = "your-device-id";
        api.ControlDevice(deviceId, "turnOn");

        Console.WriteLine("Device turned on.");
    }
}
```

## Configuration

To use the TuyaNET library, you need to provide your Tuya API credentials. You can obtain these credentials by creating
an account on the [Tuya IoT Platform](https://iot.tuya.com/) and creating a new project.

## Roadmap

- [x] Implement basic API connection
- [ ] Retrieve and manage devices (planned)
- [ ] Support for local device connections

## Contributing

Contributions are welcome! Please open an issue or submit a pull request with any improvements or bug fixes.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.

## Acknowledgements

- [Tuya IoT Platform](https://iot.tuya.com/) for providing the API
