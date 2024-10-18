---
title: Technology Stack Overview for SkillHub
description: A guide in my new Starlight docs site.
sidebar:
  order: 4
---

The SkillHub e-learning platform leverages a modern technology stack that enables scalability, performance, and flexibility for both development and user experience. The stack includes tools for backend services, frontend development, databases, messaging, monitoring, and logging. Below is a breakdown of the key technologies used and how they can be implemented within the system.

## ASP.NET Core

Usage: ASP.NET Core is the backbone for all backend microservices in SkillHub. It offers high performance and cross-platform support, ideal for building REST APIs and handling backend logic.
Implementation:
Each microservice (e.g., User Service, Course Service) is built using ASP.NET Core Web API.
It integrates easily with authentication libraries such as IdentityServer4 for managing user authentication and authorization.
It is used in conjunction with Entity Framework for database management and RabbitMQ/Kafka for message communication between services.

## Angular

Usage: Angular is used for developing the frontend of SkillHub, which is composed of multiple microfrontends. Each frontend interacts with the corresponding backend services (e.g., User Frontend, Course Frontend).
Implementation:
Angular serves as the framework for building dynamic user interfaces.
It communicates with backend services through REST APIs, enabling features like user authentication, course management, and displaying data visualizations (such as charts and progress reports).
The architecture follows a microfrontend approach, allowing the modularization of different areas like user dashboards, quizzes, and forums.

## SQL Server

Usage: SQL Server is the primary relational database for storing structured data such as user accounts, course details, and lesson information.
Implementation:
SQL Server is used in combination with Entity Framework Core to manage relational data, providing support for migrations, querying, and database management.
It stores relational data for key services like User Service, Course Service, and Lesson Service.
Transactions and complex querying, such as retrieving user progress or course statistics, are efficiently managed using SQL Server's capabilities.

## Entity Framework Core

Usage: Entity Framework Core is the Object-Relational Mapper (ORM) used to interact with SQL Server.
Implementation:
Each microservice that uses SQL Server employs Entity Framework Core for data access.
Developers can easily define models (classes) that map to SQL tables, making database operations easier and reducing the amount of boilerplate SQL code.
EF Core supports features like automatic migrations, lazy loading, and LINQ queries.

## RabbitMQ

Usage: RabbitMQ is used as the primary message broker to handle asynchronous communication between microservices, ensuring decoupling and scalability.
Implementation:
RabbitMQ is used to publish and consume messages between services, such as notifying the Notification Service when a course is completed or broadcasting analytics data from the Analytics Service.
Services communicate via RabbitMQ exchanges and queues, with queues handling tasks like quiz grading or sending notifications.

## MongoDB

Usage: MongoDB is a NoSQL database used for storing unstructured data, such as quiz results, student progress logs, and feedback.
Implementation:
The Quiz Service uses MongoDB to store quiz attempts and results in a flexible, unstructured format, which is ideal for handling varying data types.
MongoDB is chosen for its ability to scale horizontally and handle large volumes of unstructured data.
Documents in MongoDB store quiz information as JSON-like structures, allowing for rapid querying and storage of diverse data.

## ElasticSearch

Usage: ElasticSearch is used for analytics and search functionalities, providing fast and powerful querying capabilities across large datasets.
Implementation:
ElasticSearch collects and indexes data from multiple services to enable search functionality, such as searching through courses or analyzing user progress.
The Analytics Service uses ElasticSearch to aggregate data, provide reports on course popularity, and display trends in user activity.
It allows near real-time querying and is used in combination with Kibana to visualize analytics.

## SMTP

Usage: SMTP is used for sending emails from the platform, such as user notifications, quiz results, and certificates.
Implementation:
The Notification Service handles email sending via SMTP, using configurations like an email server (e.g., Postfix or an external email provider such as SendGrid).
It is responsible for sending automated emails for various events such as quiz completions, new course enrollments, or system updates.
RabbitMQ facilitates communication between services and the Notification Service for email dispatching.

## Kafka

Usage: Kafka is used for high-throughput message processing, suitable for streaming data such as analytics and logs across microservices.
Implementation:
Kafka is used to handle data streams, such as processing user activity data in real-time for the Analytics Service.
It supports distributed logging and event-driven architectures, allowing for large-scale messaging between services.
Kafka enables services to handle event-driven actions, such as real-time notifications, content recommendations, and log aggregation.

## Prometheus and Grafana

Usage: Prometheus and Grafana are used for monitoring and visualizing metrics from the microservices, ensuring system health and performance.
Implementation:
Prometheus collects real-time metrics from each microservice, such as memory usage, response times, and error rates.
Grafana is used to create dashboards for visualizing this data, enabling developers and administrators to track system performance and detect bottlenecks or failures.
Alerts can be configured in Prometheus to notify administrators when thresholds are crossed, ensuring proactive monitoring.
