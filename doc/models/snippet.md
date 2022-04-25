
# Snippet

## Structure

`Snippet`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PublishedAt` | `string` | Required | - |
| `ChannelId` | `string` | Required | - |
| `Title` | `string` | Required | - |
| `Description` | `string` | Required | - |
| `Thumbnails` | [`Models.Thumbnails`](../../doc/models/thumbnails.md) | Required | - |
| `ChannelTitle` | `string` | Required | - |
| `LiveBroadcastContent` | `string` | Required | - |
| `PublishTime` | `string` | Required | - |

## Example (as JSON)

```json
{
  "publishedAt": "03/25/2022 09:53:00",
  "channelId": "UC6jH5GNi0iOR17opA1Vowhw",
  "title": "Шум моря 🐢 музыка, расслабляющая водных животных🐋 музыка  лечащая нервы и помогающая заснуть",
  "description": "Добро пожаловать на расслабляющий музыкальный канал Lucid Dream, спасибо за вашу поддержку и любовь к каналу ...",
  "thumbnails": {
    "default": {
      "url": "https://i.ytimg.com/vi/bkrGdTvb9jU/default_live.jpg",
      "width": 120,
      "height": 90
    },
    "medium": {
      "url": "https://i.ytimg.com/vi/bkrGdTvb9jU/mqdefault_live.jpg",
      "width": 320,
      "height": 180
    },
    "high": {
      "url": "https://i.ytimg.com/vi/bkrGdTvb9jU/hqdefault_live.jpg",
      "width": 480,
      "height": 360
    }
  },
  "channelTitle": "Lucid Dream",
  "liveBroadcastContent": "live",
  "publishTime": "03/25/2022 09:53:00"
}
```

