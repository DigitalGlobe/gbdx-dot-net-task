FROM mono:3.12

ADD DotNetSampleTask /var/mono/DotNetSampleTask/
WORKDIR /var/mono/DotNetSampleTask

# Build our project
RUN nuget restore DotNetSampleTask.sln
RUN xbuild DotNetSampleTask.sln

# Change to our artifact directory
WORKDIR /var/mono/DotNetSampleTask/bin/Debug

# Entry point should be mono binary
CMD mono DotNetSampleTask.exe