# Authorization Token Management

This product provides APIs related to the token management of cloud development. You can use the authorization keys (Access ID/Client ID and Access Secret/Client Secret) to get a token to access other APIs.

## Implemented functions

- [X] [Sign Requests for Cloud Authorization](https://developer.tuya.com/en/docs/iot/new-singnature?id=Kbw0q34cs2e5g): When you make requests to APIs, you must provide a signature to verify your identity and ensure data security.

- [X] [Authorization Token Management](https://developer.tuya.com/en/docs/cloud/authorization-management?id=Kaiuy9cjp8kr2): This product provides APIs related to the token management of cloud development. You can use the authorization keys (Access ID/Client ID and Access Secret/Client Secret) to get a token to access other APIs.
  - [X] [Refresh Token](https://developer.tuya.com/en/docs/cloud/80bb968f1d?id=Ka7kjv3j8jgvr): In the cloud-to-cloud integration scenarios, you can request cloud API authorizations from the platform in simple mode and get a token implicitly.
  - [X] [Get a Token](https://developer.tuya.com/en/docs/cloud/6c1636a9bd?id=Ka7kjumkoa53v): Each OAuth token is valid for two hours. After expiration, you need to use refresh_token to replace the previous token