#!/bin/bash

rm -fr proto/js
rm -fr proto/csharp
rm -fr proto/swift

mkdir proto/js
mkdir proto/csharp
mkdir proto/swift

cd proto

protoc --csharp_out=csharp *.proto
protoc --swift_out=swift *.proto
protoc --js_out=import_style=commonjs,binary:js *.proto