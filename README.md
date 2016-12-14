# GBDX .NET Sample Task

A simple GBDX task written in .NET via Mono that manipulates string in puts & outputs.

For more details on Mono (the currently supported way to run Windows code in GBDX) see: http://www.mono-project.com/docs/about-mono/compatibility/

# Contents of this Repo

* ```DotNetSampleTask/*``` The .NET code of the sample task
* ```Dockerfile``` the Dockerfile used to build the image of the .NET task
* ```task.json``` The task definition that would e.g. be submitted to the GBDX task registration endpoint

# Building the task

```
docker build -t <your-task-name> .
```
