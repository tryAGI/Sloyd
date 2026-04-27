#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: locally maintained from https://sloyd.gitbook.io/documentation/other-products/deprecated-products/api/api-endpoints.md
dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace Sloyd \
  --clientClassName SloydClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
