# System architecture patterns

## 1. Layered (n-tier) Architecture
**Definition**: A layered architecture organizes the system into a set of layers, each with a specific responsibility. Common layers include presentation, business logic, and data access.

**Analogy**: Think of a cake with multiple layers. Each layer has a specific role: the base layer is the foundation, the middle layers add flavor and texture, and the top layer is the decoration.

## 2. Microservices Architecture
**Definition**: A microservices architecture structures an application as a collection of loosely coupled, independently deployable services that communicate over a network.

**Analogy**: Imagine a fleet of food trucks, each specializing in a different type of cuisine. One truck serves tacos, another serves sushi, and another serves burgers. Each truck operates independently and can be replaced or updated without affecting the others.

## 3. Event-Driven Architecture
**Definition**: An event-driven architecture is a software design pattern in which decoupled components communicate by producing and consuming events.

**Analogy**: Think of a relay race where runners pass a baton to the next runner. Each runner only starts running when they receive the baton.

## 4. Client-Server Architecture
**Definition**: A client-server architecture separates the system into two main components: clients, which make requests, and servers, which process and respond to those requests.

**Analogy**: Consider a restaurant where customers (clients) place orders with the waiter (server). The waiter takes the orders, passes them to the kitchen, and then brings the prepared food back to the customers.

## 5. Service-Oriented Architecture (SOA)
**Definition**: Service-Oriented Architecture (SOA) is a design pattern where services are provided to other components by application components, through a communication protocol over a network.

**Analogy**: Think of a large company with different departments (HR, Finance, IT) that provide services to each other. For example, HR provides employee data to Finance for payroll processing.

## 6. Monolithic Architecture
**Definition**: A monolithic architecture is a unified model for designing a software application where all functions and features are interwoven into a single program.

**Analogy**: Imagine a single, large department store where everything you need is available under one roof: groceries, clothing, electronics, etc.

## 7. Onion Architecture
**Definition**: Onion Architecture is a layered architecture that emphasizes the separation of concerns, making the core business logic independent of external dependencies like databases and user interfaces.

**Analogy**: Think of an onion with layers. The innermost layer represents the core business logic, while the outer layers represent interfaces and infrastructure. Peeling an onion doesn't change the core, similar to how changes in external layers don't affect the core business logic.

## 8. Domain-Driven Design (DDD)
**Definition**: Domain-Driven Design (DDD) is an approach to software development that focuses on modeling the core business domain and using the model to drive the design of the software.

**Analogy**: Imagine building a city where every structure and street is designed according to the city's specific needs and cultural aspects. Similarly, DDD ensures that the software closely aligns with the business domain, making it more intuitive and effective.

## 9. Clean Architecture
**Definition**: Clean Architecture is a software design philosophy that emphasizes separation of concerns and decoupling, allowing the business logic to be independent of frameworks, databases, and other external concerns.

**Analogy**: Consider a well-organized workshop where tools are grouped by function and easily accessible, but not tied to a specific project. This allows you to switch projects without reorganizing the entire workshop. Clean Architecture keeps the core logic independent, making the system adaptable and maintainable.
