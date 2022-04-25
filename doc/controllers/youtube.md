# Youtube

```csharp
YoutubeController youtubeController = client.YoutubeController;
```

## Class Name

`YoutubeController`


# Youtube Searcher

```csharp
YoutubeSearcherAsync(
    string part,
    string channelID = null,
    string topicId = null,
    string type = null,
    string q = null,
    Models.VideoTypeEnum? videoType = null,
    Models.EventTypeEnum? eventType = null,
    Models.ChannelTypeEnum? channelType = null,
    Models.VideoCaptionEnum? videoCaption = null,
    Models.OrderEnum? order = null,
    Models.VideoLicenseEnum? videoLicense = null,
    Models.VideoSyndicatedEnum? videoSyndicated = null,
    Models.VideoEmbeddableEnum? videoEmbeddable = null,
    Models.VideoDurationEnum? videoDuration = null,
    Models.VideoDimensionEnum? videoDimension = null,
    Models.VideoDefinitionEnum? videoDefinition = null,
    string pageToken = null,
    string key = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `part` | `string` | Query, Required | The part parameter specifies a comma-separated list of one or more search resource properties that the API response will include |
| `channelID` | `string` | Query, Optional | The channelId parameter indicates that the API response should only contain resources created by the channel. |
| `topicId` | `string` | Query, Optional | - |
| `type` | `string` | Query, Optional | - |
| `q` | `string` | Query, Optional | - |
| `videoType` | [`Models.VideoTypeEnum?`](../../doc/models/video-type-enum.md) | Query, Optional | - |
| `eventType` | [`Models.EventTypeEnum?`](../../doc/models/event-type-enum.md) | Query, Optional | - |
| `channelType` | [`Models.ChannelTypeEnum?`](../../doc/models/channel-type-enum.md) | Query, Optional | - |
| `videoCaption` | [`Models.VideoCaptionEnum?`](../../doc/models/video-caption-enum.md) | Query, Optional | - |
| `order` | [`Models.OrderEnum?`](../../doc/models/order-enum.md) | Query, Optional | - |
| `videoLicense` | [`Models.VideoLicenseEnum?`](../../doc/models/video-license-enum.md) | Query, Optional | - |
| `videoSyndicated` | [`Models.VideoSyndicatedEnum?`](../../doc/models/video-syndicated-enum.md) | Query, Optional | - |
| `videoEmbeddable` | [`Models.VideoEmbeddableEnum?`](../../doc/models/video-embeddable-enum.md) | Query, Optional | - |
| `videoDuration` | [`Models.VideoDurationEnum?`](../../doc/models/video-duration-enum.md) | Query, Optional | - |
| `videoDimension` | [`Models.VideoDimensionEnum?`](../../doc/models/video-dimension-enum.md) | Query, Optional | - |
| `videoDefinition` | [`Models.VideoDefinitionEnum?`](../../doc/models/video-definition-enum.md) | Query, Optional | - |
| `pageToken` | `string` | Query, Optional | - |
| `key` | `string` | Query, Optional | - |

## Response Type

[`Task<Models.YoutubeSearch>`](../../doc/models/youtube-search.md)

## Example Usage

```csharp
string part = "part2";

try
{
    YoutubeSearch result = await youtubeController.YoutubeSearcherAsync(part, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`BadRequestException`](../../doc/models/bad-request-exception.md) |
| 401 | Unauthorized | [`UnauthorizedException`](../../doc/models/unauthorized-exception.md) |
| 403 | Forbidden | [`ForbiddenExpcetionException`](../../doc/models/forbidden-expcetion-exception.md) |
| 404 | Not found | [`NotFoundException`](../../doc/models/not-found-exception.md) |
| 409 | Conflict | [`ConflictExcpetionException`](../../doc/models/conflict-excpetion-exception.md) |

