# MyIP

Simple Azure function that returns visitors public IP address.

## Usage

### Browser

Copy paste following address in your favorite browser or just click on the link below to open it in your default one.

https://iiric.azurewebsites.net/api/MyIP

### PowerShell

```PowerShell
irm https://iiric.azurewebsites.net/api/MyIP
```
Command `irm` is alias for `Invoke-RestMethod` commandlet.

### Curl

```shell
curl https://iiric.azurewebsites.net/api/MyIP
```
