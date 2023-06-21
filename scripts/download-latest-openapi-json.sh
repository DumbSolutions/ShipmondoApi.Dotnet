curl https://app.shipmondo.com/api/public/v3/elements.json --output elements.json && \
  node fix-broken-json.js elements.json && \
  node patch-openapi-document.js elements.json