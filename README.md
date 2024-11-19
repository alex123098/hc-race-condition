# Hotchocolate 14.1.0 possible race condition in request batching processing

## To reproduce the issue

1. Clone the repository
2. Run the project with `dotnet run`
3. Run the `repro.sh` script.

## Expected output

```text
---
Content-Type: application/json; charset=utf-8

{"requestIndex":1,"data":{"author":{"name":"Jon Skeet"}}}
---
Content-Type: application/json; charset=utf-8

{"requestIndex":0,"data":{"book":{"title":"C# in depth."}}}
-----
```

or

```text

---
Content-Type: application/json; charset=utf-8

{"requestIndex":0,"data":{"book":{"title":"C# in depth."}}}
---
Content-Type: application/json; charset=utf-8

{"requestIndex":1,"data":{"author":{"name":"Jon Skeet"}}}
-----
```

## Actual output

4 times out of 5 the server returns result of only one query.
The query that is returned seems to be random.

## Note

The issue doesn't occur if you remove calls to `Task.Delay` in lines 7 and 13 of `Types/Query.cs`.