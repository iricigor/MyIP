# MyIP

Simple Azure function that returns the client's public IP address.

## Usage

### Browser

Copy-paste following address in your favorite browser or just click on the link below to open it in your default one.

https://az.iric.online/myip

### PowerShell

```PowerShell
irm az.iric.online/myip
```
Command `irm` is an alias for `Invoke-RestMethod` commandlet.

This example works both on Linux and Windows.

### Curl

```shell
curl https://az.iric.online/myip
```

### Azure Functions

The web site is published using Azure Functions.
Its original address is https://iiric.azurewebsites.net/MyIP

All commands above work also with this long name.

## Security

Deployed application is configured to use only HTTPS protocol with minimum TLS 1.2.

Certificates are provided to secure both sites `az.iric.online` and `iiric.azurewebsites.net`

## License 

MyIP is licensed under the [MIT license](./LICENSE).
