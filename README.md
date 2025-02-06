# DotNet
# Create an webapi project using cmd below:
dotnet new webapi -n HelloWorldApi

# Switch to project directory
cd HelloWorldApi

# Change the program.cs and run the project using
dotnet run

# For dokcerfile .
Used multi-stage build.
The SDK image is only used for building (not included in the final image)
The runtime image is much smaller, reducing the container size.
It keeps the final image clean and optimized for production.