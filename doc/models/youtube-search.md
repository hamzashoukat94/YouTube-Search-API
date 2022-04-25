
# Youtube Search

## Structure

`YoutubeSearch`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Kind` | `string` | Required | - |
| `Etag` | `string` | Required | - |
| `NextPageToken` | `string` | Required | - |
| `RegionCode` | `string` | Required | - |
| `PageInfo` | [`Models.PageInfo`](../../doc/models/page-info.md) | Required | - |
| `Items` | [`List<Models.Item>`](../../doc/models/item.md) | Required | - |

## Example (as JSON)

```json
{
  "kind": "youtube#searchListResponse",
  "etag": "pwgRpl2RS_GQPveJrnPLEaOruQo",
  "nextPageToken": "CAUQAA",
  "regionCode": "PK",
  "pageInfo": {
    "totalResults": 1000000,
    "resultsPerPage": 5
  },
  "items": [
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
    },
    {
      "kind": "youtube#searchResult",
      "etag": "d9VVcqiI8a8i61KbE638qCOrgSk",
      "id": {
        "kind": "youtube#video",
        "videoId": "eOTBID-M4Eg"
      },
      "snippet": {
        "publishedAt": "2019-02-15T16:16:50Z",
        "channelId": "UC4iVQVvdlO30dQjUIfmbR-Q",
        "title": "Μουτσινάς  Δεν έδωσε το αυτοκίνητο για δεύτερη φορά",
        "description": "Description.",
        "thumbnails": {
          "default": {
            "url": "https://i.ytimg.com/vi/eOTBID-M4Eg/default.jpg",
            "width": 120,
            "height": 90
          },
          "medium": {
            "url": "https://i.ytimg.com/vi/eOTBID-M4Eg/mqdefault.jpg",
            "width": 320,
            "height": 180
          },
          "high": {
            "url": "https://i.ytimg.com/vi/eOTBID-M4Eg/hqdefault.jpg",
            "width": 480,
            "height": 360
          }
        },
        "channelTitle": "GossiptvgrVideos",
        "liveBroadcastContent": "none",
        "publishTime": "2019-02-15T16:16:50Z"
      }
    },
    {
      "kind": "youtube#searchResult",
      "etag": "eCNOrcVL23kJGTccjeHw3Sg-BDg",
      "id": {
        "kind": "youtube#video",
        "videoId": "2m4ltW52HAE"
      },
      "snippet": {
        "publishedAt": "2019-11-22T09:07:14Z",
        "channelId": "UCeMy_sdL64HpvxqUoYbXpow",
        "title": "FURKAN ANDIÇ ROL ARKADAŞI AYBÜKE PUSAT İLE AŞK YAŞIYOR MU, YAKIŞIKLI OYUNCU NELER SÖYLEDİ?",
        "description": "Her Yerde Sen” adlı dizide başrolü paylaştığı Aybüke Pusat ile aşk yaşadığı konuşulan Furkan Andıç, iddiaları nasıl karşıladı?",
        "thumbnails": {
          "default": {
            "url": "https://i.ytimg.com/vi/2m4ltW52HAE/default.jpg",
            "width": 120,
            "height": 90
          },
          "medium": {
            "url": "https://i.ytimg.com/vi/2m4ltW52HAE/mqdefault.jpg",
            "width": 320,
            "height": 180
          },
          "high": {
            "url": "https://i.ytimg.com/vi/2m4ltW52HAE/hqdefault.jpg",
            "width": 480,
            "height": 360
          }
        },
        "channelTitle": "FORX5 TV",
        "liveBroadcastContent": "none",
        "publishTime": "2019-11-22T09:07:14Z"
      }
    },
    {
      "kind": "youtube#searchResult",
      "etag": "hEzpbR7MERf9q7vhSNdbrHIeXcs",
      "id": {
        "kind": "youtube#video",
        "videoId": "jia2HombSzQ"
      },
      "snippet": {
        "publishedAt": "2018-06-26T21:12:15Z",
        "channelId": "UCy3DbVl0K1qj0e8jGAOYgPg",
        "title": "Shagabond  - Panic",
        "description": "\"I started writing 'Panic' back in early 2015 during a trip overseas. It originally had a Weeknd vocal sample lingering in the ...",
        "thumbnails": {
          "default": {
            "url": "https://i.ytimg.com/vi/jia2HombSzQ/default.jpg",
            "width": 120,
            "height": 90
          },
          "medium": {
            "url": "https://i.ytimg.com/vi/jia2HombSzQ/mqdefault.jpg",
            "width": 320,
            "height": 180
          },
          "high": {
            "url": "https://i.ytimg.com/vi/jia2HombSzQ/hqdefault.jpg",
            "width": 480,
            "height": 360
          }
        },
        "channelTitle": "Future Classic",
        "liveBroadcastContent": "none",
        "publishTime": "2018-06-26T21:12:15Z"
      }
    },
    {
      "kind": "youtube#searchResult",
      "etag": "XK_iHeU_ax4iY0zhIjCt1eDDDsc",
      "id": {
        "kind": "youtube#video",
        "videoId": "D7xxC6rAB5w"
      },
      "snippet": {
        "publishedAt": "2020-03-02T21:19:39Z",
        "channelId": "UCy3DbVl0K1qj0e8jGAOYgPg",
        "title": "Clubfeet - Capetown (Panama Remix) [Official Audio]",
        "description": "Another flashback - our very own Panama really brought the disco to Clubfeet's 2013 single 'Cape Town'. Subscribe to our ...",
        "thumbnails": {
          "default": {
            "url": "https://i.ytimg.com/vi/D7xxC6rAB5w/default.jpg",
            "width": 120,
            "height": 90
          },
          "medium": {
            "url": "https://i.ytimg.com/vi/D7xxC6rAB5w/mqdefault.jpg",
            "width": 320,
            "height": 180
          },
          "high": {
            "url": "https://i.ytimg.com/vi/D7xxC6rAB5w/hqdefault.jpg",
            "width": 480,
            "height": 360
          }
        },
        "channelTitle": "Future Classic",
        "liveBroadcastContent": "none",
        "publishTime": "2020-03-02T21:19:39Z"
      }
    }
  ]
}
```

