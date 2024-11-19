#!/usr/bin/env bash

PORT=$1
if [ -z "${PORT}" ]; then
  PORT=5095
fi

curl "http://localhost:${PORT}/graphql" \
  -XPOST \
  -H 'Content-Type: application/json' \
  --data '[{"operationName": "GetBook","query":"query GetBook{book{title}}"},{"operationName":"GetAuthor","query":"query GetAuthor{author{name}}"}]'