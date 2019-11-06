# ASP.NET Core Web API学习笔记

# Learning ASP.NET Core Web API

## 关于ASP.NET Core MVC

ASP.NET Core MVC提供以下主要功能特性:

* Routing
* Model binding
* Model validation
* Dependency injection
* Filters
* Areas
* Web APIs
* Testability
* Razor view engine
* Strongly typed views
* Tag Helpers
* View Components

其中Routing, Model binding, Model validation, Dependency injection, Filters, Areas, Web APIs等特性在Web API开发中都需要了解.

### Filters

Filters是ASP.NET Core中实现的AOP编程方式.Filters可以用来处理横切关注点.Filters通过管道的方式运行.Filters管道在ASP.NET Core
选定action后被触发.

Filter类型及管道的内部执行顺序:

1. 中间件
2. Authorization filters
3. Resource filters: OnResourceExecuting
4. Exception filters
5. Model binding
6. Action filters(before)
7. Action execution
8. Action filters(after)
9. Result filters
10. Resource filters: OnResourceExecuted

Filters分为同步和异步两种.

## 关于ASP.NET Core Web API

## 关于Nancy

## 关于ASP.NET Core RESTful API和OData

## 关于ASP.NET Core SignalR

