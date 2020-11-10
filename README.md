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

In the folder of the fable-fragment project you could run;

```bash
dotnet fable
```
This will produce the fragment.js file with import of needed fable files.

If you run;
```bash
dotnet fable watch src --run parcel index.html
```
This will then run parcel and start a server, for development.

For a "production" dist run;
```bash
dotnet fable watch src --run parcel build index.html
```