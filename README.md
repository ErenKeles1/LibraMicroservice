# 📚 LibraMicroservice (Book Store Backend)

![.NET](https://img.shields.io/badge/.NET-6.0-purple) ![MongoDB](https://img.shields.io/badge/Database-MongoDB-green) ![Architecture](https://img.shields.io/badge/Architecture-Microservices-blue) ![Status](https://img.shields.io/badge/Status-In%20Development-yellow)

**LibraMicroservice** is a scalable, modular, and distributed backend system designed for a digital library and book e-commerce platform. 

This project demonstrates the implementation of **Microservices Architecture** using **.NET 6**, adhering to **Clean Architecture** and **SOLID principles**. It is designed to handle high-traffic scenarios with independent services communicating via synchronous and asynchronous methods.

## 🚀 Tech Stack & Tools

### Core Technologies
* **.NET 6 Core Web API**
* **Entity Framework Core** (Code First Approach)
* **MongoDB** (NoSQL Database for Catalog)
* **AutoMapper** (Object-Object Mapping)
* **Swagger / OpenAPI** (Documentation)

### Microservices Architecture (Roadmap)
The project is being developed in phases. Below is the technology stack planned for the complete system:

* **API Gateway:** Ocelot
* **Message Broker:** RabbitMQ (MassTransit)
* **Authentication:** IdentityServer4 (OAuth2 & OpenID Connect)
* **Caching:** Redis (Distributed Cache for Basket Service)
* **Containerization:** Docker & Docker Compose
* **Orchestration:** Portainer / Kubernetes

---

## 🏗️ Microservices Breakdown

| Service Name | Database | Responsibility | Status |
| :--- | :--- | :--- | :--- |
| **Catalog Service** | MongoDB | Manages Books, Authors, and Categories. | ✅ Completed |
| **Discount Service** | MSSQL | Manages Coupons and Discounts (Dapper). | ✅ Completed |
| **Basket Service** | Redis | Temporary cart storage for users. | 📅 Planned |
| **Order Service** | MSSQL | Handles order placement (CQRS Pattern). | 📅 Planned |
| **Identity Service** | SQL Server | Centralized Auth & Token Management. | 📅 Planned |
| **Cargo Service** | SQL Server | Logistics and shipment tracking. | 📅 Planned |

---

## ⚙️ Getting Started

### Prerequisites
* [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
* [MongoDB Community Server](https://www.mongodb.com/try/download/community) (or Docker)
* Visual Studio 2022

### Installation
1. **Clone the repository**
   ```bash
   git clone https://github.com/ErenKeles1/LibraMicroservice.git