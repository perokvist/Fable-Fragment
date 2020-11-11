# Fable-Fragement

A sample of a fragment with behavior written in fable.

## Prerequisites
- dotnetsdk
- node
- parcel

In the root of the repository run;

```bash
dotnet tool restore
```

```bash
dotnet watch -p .\src\Web\ run
```

```bash
dotnet fable watch .\src\FableFragment\ --runWatch parcel build .\src\FableFragment\Fragment.fs.js -d .\src\web\wwwroot\dist
```
> build is optional



[?](https://www.compositional-it.com/news-blog/5-reasons-to-use-f-to-generate-html/)