# .NET Core Clean Architecture Project 
## Student Management System Backend 📚🎓

## Overview

This project is a .NET Core application built on the principles of Clean Architecture, designed to provide a modular and maintainable solution. This .NET 8 application is designed to handle the server-side logic for managing student-related activities. Below, you'll find an overview of the key aspects of this project. 

## Project Architecture

The project follows the Clean Architecture pattern, separating concerns into distinct layers:

**Presentation Layer**: Contains the application's user interface, controllers, and views.

**Application Layer**: Implements use cases and orchestrates the flow of data between the Presentation and Domain layers.

**Domain Layer**: Holds the business logic, entities, and domain services.

**Infrastructure Layer**: Deals with external concerns such as databases, external services, and implementations of repository interfaces.

## Design Patterns

The project incorporates several design patterns to enhance its structure and maintainability:

1. **Repository Pattern**: Enables a separation of concerns by abstracting the data access logic into repositories.

2. **Unit of Work Pattern**: Manages the transactional boundaries and ensures a consistent state of the data.

## Dependency Injection

The project utilizes Dependency Injection to promote loose coupling and enhance testability. This allows for easy substitution of components and facilitates a modular and scalable architecture.

## Code Reusability

A key focus of development was code reusability. Components and modules are designed with a mindset to maximize reuse, promoting a more efficient and maintainable codebase.

## SOLID Principles

The SOLID principles (Single Responsibility, Open-Closed, Liskov Substitution, Interface Segregation, and Dependency Inversion) are adhered to throughout the codebase, promoting a high level of code quality, flexibility, and maintainability.

## Entity Framework and EF Core Code-First Approach

Entity Framework is employed for object-relational mapping (ORM), with an emphasis on the Code-First approach. This allows for seamless mapping between domain entities and the database schema.

## Data Migration

The project leverages Entity Framework Core's migration capabilities to manage database schema changes over time. This ensures a smooth and versioned evolution of the database structure.

## DTO Models and AutoMapper

DTO (Data Transfer Object) models are used to shape data for specific use cases. AutoMapper is employed to streamline the mapping process between domain entities and DTO models, reducing boilerplate code and enhancing maintainability.

## Technologies Used

- **.NET 8:** Utilizing the powerful features of .NET 8 for robust and efficient server-side development.

## Project Structure

The backend is organized into the following modules, following a clean architecture:

- **StudentManagement.API:** Manages API controllers and their interactions with the application.

- **StudentManagement.Application:** Implements use cases and business logic for student management.

- **StudentManagement.Infrastructure:** Handles external concerns such as database access and third-party integrations.

- **StudentManagement.Domain:** Holds the core domain logic and business entities for the student management system.

- **StudentManagement.Model:** Represents the data models and entities used throughout the application.

## Getting Started

To run the backend application locally, follow these steps:

1. Clone the repository.
2. Navigate to the `StudentManagement.API` directory.
3. Build and run the application using your preferred development environment.
