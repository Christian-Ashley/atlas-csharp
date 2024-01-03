#!/usr/bin/env bash

# Bash script to install .NET Core 2.1 on Ubuntu

echo "Determining Ubuntu version..."
# Get Ubuntu version
repo_version=$(if command -v lsb_release &> /dev/null; then 
    lsb_release -r -s
else 
    grep -oP '(?<=^VERSION_ID=).+' /etc/os-release | tr -d '"'
fi)

echo "Ubuntu version detected: $repo_version"
echo "Adding Microsoft package signing key and repository..."

# Download Microsoft signing key and repository
wget https://packages.microsoft.com/config/ubuntu/$repo_version/packages-microsoft-prod.deb -O packages-microsoft-prod.deb

# Install Microsoft signing key and repository
sudo dpkg -i packages-microsoft-prod.deb

# Clean up
rm packages-microsoft-prod.deb

echo "Updating package list..."
# Update packages
sudo apt update

echo "Installing .NET Core 2.1 SDK..."
# Install .NET Core 2.1
sudo apt install dotnet-sdk-2.1

echo ".NET Core 2.1 installation completed."
