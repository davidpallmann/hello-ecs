# Hello, ECS & Fargate!

This is the code project for the [Hello, ECS & Fargate!](https://davidpallmann.hashnode.dev/hello-ecs-and-fargate) blog post. 

This episode: Amazon Elastic Container Service & AWS Fargate. In this [Hello, Cloud](https://davidpallmann.hashnode.dev/series/hello-cloud) blog series, we're covering the basics of AWS cloud services for newcomers who are .NET developers. If you love C# but are new to AWS, or to this particular service, this should give you a jumpstart.

In this post we'll introduce Amazon Elastic Container Service (ECS) and AWS Fargate and explain their differences. We'll use AWS Fargate to host a simple .NET "Hello, Cloud" web API on ECS in a Linux container. We'll do this step-by-step, making no assumptions other than familiarity with C# and Visual Studio. We're using Visual Studio 2022 and .NET 6.

## Our Hello, ECS Project

We’re going to create a .NET 6 web API project, test it locally, then publish to AWS ECS right from Visual Studio. The AWS publish operation will containerize the service (in Linux) and publish to ECS, where Fargate will run the container serverless. From there, we'll add a second container, this time using the AWS console.

See the blog post for the tutorial to create this project and run it on AWS.

