# MyIP

Simple Azure function that returns client's public IP address.

## Usage

### Browser

Copy paste following address in your favorite browser or just click on the link below to open it in your default one.

https://az.iric.online/myip

### PowerShell

```PowerShell
irm az.iric.online/myip
```
Command `irm` is alias for `Invoke-RestMethod` commandlet.

This example work both on Linux and Windows.

### Curl

```shell
curl https://az.iric.online/myip
```

### Azure Functions

Web site is published using Azure Functions.
It's original address is https://iiric.azurewebsites.net/MyIP

All commands above work also with this longer name.

## Security

Deployed application is configured to use only HTTPS with minimum TLS 1.2.

Certificate is provided to secure both sites `az.iric.online` and `iiric.azurewebsites.net`
