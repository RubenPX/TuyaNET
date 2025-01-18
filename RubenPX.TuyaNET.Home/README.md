# Authorization Token Management

This product provides APIs related to the token management of cloud development. You can use the authorization keys (Access ID/Client ID and Access Secret/Client Secret) to get a token to access other APIs.

## Implementations

[Smart Home Basic Service](https://developer.tuya.com/en/docs/cloud/smart-home-basic-service?id=Kconis1yii4be): Provides Tuya smart home basic abilities

## Implemented API

| Api Route Name | URL | Description |
| -------------- | --- | ----------- |
| [Add Home](https://developer.tuya.com/en/docs/cloud/b3014bea96?id=Kawfjdqri4xgi) | `POST: /v1.0/home/create-home` | Add a home and rooms for a specified user.
| [Search for Home](https://developer.tuya.com/en/docs/cloud/0dbe66fef6?id=Kawfjdzu0dava) | `GET: /v1.0/homes/{home_id}` | Based on the home ID, query the basic information about the specified home. |
| [Modify Home](https://developer.tuya.com/en/docs/cloud/334c5cfcdb?id=Kawfje8vm4n40) | `PUT: /v1.0/homes/{home_id}` | Based on the home ID, modify home information |
| [Delete Home](https://developer.tuya.com/en/docs/cloud/6889fd21cf?id=Kawfjei1b8ci4) | `DELETE: /v1.0/homes/{home_id}` | Delete home based on home ID |

## To be implemented

| Api Route Name | URL | Description |
| -------------- | --- | ----------- |
| [Query Devices under Home](https://developer.tuya.com/en/docs/cloud/d7ee73aadb?id=Kawfjer0wkt2a) | `GET: /v1.0/homes/{home_id}/devices` | Based on the home ID, query a list of devices in the specified home. |
| [Query Home Members](https://developer.tuya.com/en/docs/cloud/9e1fa96cca?id=Kawfjf04nr6dd) | `GET: /v1.0/homes/{home_id}/members` | Query the list of home members based on the home ID. |
| [Add Home Member](https://developer.tuya.com/en/docs/cloud/83bc26c9d3?id=Kawfjf96h07rc) | `POST: /v1.0/homes/{home_id}/members` | Add members to a specified home. |
| [Modify Home Member](https://developer.tuya.com/en/docs/cloud/9a1353697a?id=Kawfjfigqx7va) | `PUT: /v1.0/homes/{home_id}/members/{uid}` | Used to set administrator or non-administrative role permissions for family members. |
| [Delete Home Member](https://developer.tuya.com/en/docs/cloud/cd4ca9d9af?id=Kawfjfrashst0) | `DELETE: /v1.0/homes/{home_id}/members/{uid}` | Delete a member of the specified home. |
| [Add Room](https://developer.tuya.com/en/docs/cloud/42590b6dcc?id=Kawfjg0brs1zl) | `POST: /v1.0/homes/{home_id}/room` | Add a room under the family. |
| [Query Room List](https://developer.tuya.com/en/docs/cloud/5a2fe10caa?id=Kawfjg9hodgdw) | `GET: /v1.0/homes/{home_id}/rooms` | Query the list of rooms under a specified home. |
| [Delete Room](https://developer.tuya.com/en/docs/cloud/cf7a22a637?id=Kawfjgin5zae3) | `DELETE: /v1.0/homes/{home_id}/rooms/{room_id}` | You can delete the specified room in the family through this API. |
| [Modify Room Name](https://developer.tuya.com/en/docs/cloud/04635dba27?id=Kawfjgribi8tq) | `PUT: /v1.0/homes/{home_id}/rooms/{room_id}` | Modify the name of a room in the family. |
| [Query Room Device](https://developer.tuya.com/en/docs/cloud/23ecef19df?id=Kawfjh0l67rd9) | `GET: /v1.0/homes/{home_id}/rooms/{room_id}/devices` | Used to query the equipment in the family room. |
| [Query User Home List](https://developer.tuya.com/en/docs/cloud/f5dd40ed14?id=Kawfjh9hpov1n) | `GET: /v1.0/users/{uid}/homes` | Based on the user ID, query the list of homes where the specified user belongs. |
| [Add Device to Room](https://developer.tuya.com/en/docs/cloud/580cf6d356?id=Kawfjhifn3l0x) | `POST: /v1.0/homes/{home_id}/rooms/{room_id}/devices` | You can add devices in the specified family room through this API. |
| [Modify Room Devices](https://developer.tuya.com/en/docs/cloud/ecdaced5c6?id=Kawfjhri0bzhd) | `PUT: /v1.0/homes/{home_id}/rooms/{room_id}/devices` | Modify the devices in a room under a specified home. |
| [Delete Device from Room](https://developer.tuya.com/en/docs/cloud/d3e25dfd74?id=Kawfji0jh3voy) | `DELETE: /v1.0/homes/{home_id}/rooms/{room_id}/devices` | Based on the home ID, room ID, and device IDs, delete devices from the specified room in a home. |
| [Get Device List](https://developer.tuya.com/en/docs/cloud/7ccd629a6c?id=Kconjb15xpvd3) | `GET: /v1.0/devices` | Get a list of devices and device status based on the application, product, or device ID. |
