#!/bin/bash

# Specify the file path
file_path="src/ShipmondoApi.Dotnet/ShipmondoApi.Dotnet.csproj"

# Temporary file to store the modified content
temp_file="/tmp/shipmondo-temp-file.csproj"

# Function to increment the version string
increment_version() {
  local version=$1
  local increment_type=$2

  # Split the version string into major, minor, and patch components
  IFS='.' read -r -a version_parts <<< "$version"
  major=${version_parts[0]}
  minor=${version_parts[1]}
  patch=${version_parts[2]}

  # Increment the appropriate version component
  case "$increment_type" in
    major)
      major=$((major + 1))
      minor=0
      patch=0
      ;;
    minor)
      minor=$((minor + 1))
      patch=0
      ;;
    patch)
      patch=$((patch + 1))
      ;;
    *)
      echo "Invalid increment type. Please specify 'major', 'minor', or 'patch'."
      exit 1
      ;;
  esac

  # Return the incremented version string
  echo "$major.$minor.$patch"
}

if [ $# -ne 1 ]; then
  echo "Usage: ./version-bump.sh [major|minor|patch]"
  exit 1
fi

increment_type="$1"

new_version="";

# Read each line of the file
while IFS= read -r line; do
  # Check if the line has version tag
  if [[ $line == *"<Version>"*"</Version>" ]]; then
    # Extract the version string between the tags
    version=$(echo "$line" | sed -n 's/.*<Version>\(.*\)<\/Version>.*/\1/p')

    # Increment the version string
    new_version=$(increment_version "$version" "$increment_type")

    modified_line=$(echo "$line" | sed "s/$version/$new_version/")

    # Replace the line with new version"
    line=$(echo "$line" | sed "s/$version/$new_version/")
  fi
  # Append the modified or original line to the temporary file
  echo "$line" >> "$temp_file"
done < "$file_path"

# Overwrite the original file with the modified content
mv "$temp_file" "$file_path"

echo "Updated csproj to $new_version"
scripts/generate-source.sh
git add .openapi-generator/FILES src README.md
git commit -m "Bump version $new_version";
git tag "v$new_version"