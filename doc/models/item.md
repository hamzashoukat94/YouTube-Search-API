
# Item

## Structure

`Item`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Kind` | `string` | Required | - |
| `Etag` | `string` | Required | - |
| `Id` | [`Models.Id`](../../doc/models/id.md) | Required | - |
| `Snippet` | [`Models.Snippet`](../../doc/models/snippet.md) | Required | - |

## Example (as JSON)

```json
{
  "kind": "youtube#searchResult",
  "etag": "7JMdSY4d9yNyqdsBdJ-EBJjQuzw",
  "id": {
    "kind": "youtube#video",
    "videoId": "bkrGdTvb9jU"
  },
  "snippet": {
    "publishedAt": "2022-03-25T09:53:00Z",
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
    "publishTime": "2022-03-25T09:53:00Z"
  }
}
```

