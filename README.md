# Azure Search Workshop

Serverless is reshaping the way developers think about software/system architectures. By simplifying infrastructure, technologies such as Functions, Logic Apps, and ServiceBus have made is easier to develop reusable APIs (consumed by mobile, desktop, web, and IoT clients). 

The burden of managing infrastructure no longer lies with the developer, leaving them to focus on solving the problem (i.e. writing code) instead of worrying about managing the environment. Infrastructure professionals also benefit from PaaS; thanks to auto-scale and micro-billing, there are financial savings to be realized without sacrificing scalability per demand.

In this workshop, you will develop an end-to-end data discovery solution using:
* [Cosmos DB](https://azure.microsoft.com/en-us/services/cosmos-db/)— for data storage;
* [Logic Apps](https://azure.microsoft.com/en-us/services/logic-apps/)- to import the data into Cosmos DB;
* [Functions](https://azure.microsoft.com/en-us/services/functions/)— for sanitization of data prior to storage in Cosmos DB;
* [Azure Search](https://azure.microsoft.com/en-us/services/search/)— to facilitate discovery of data stored in the databse;
* [Bot Service](https://azure.microsoft.com/en-us/services/bot-service/)— to query the data base using natural language;
* [LUIS](https://azure.microsoft.com/en-us/services/cognitive-services/language-understanding-intelligent-service/)— to provide natural language processing functionality to the chatbot;
* [VSTS](https://azure.microsoft.com/en-us/services/visual-studio-team-services/)— for DevOps around the development and deployment of the chatbot's code;
* [API Management](https://azure.microsoft.com/en-us/services/api-management/)— for management of access to the aforementioned services.

---

## Target Audience
* Technical roles (engineers, architects, infrastructure managers, etc.).
* Anyone interested in automating business processes.
* Anyone interested in learning about Azure and Serverless.

## Requirements
* [Visual Studio](https://www.visualstudio.com/vs/) (with _Azure Development_ tools installed)
* [Azure Subscription](https://azure.microsoft.com/en-us/free/)
* [Postman](https://www.getpostman.com) or a similar HTTP request simulator
* Access to the [LUIS Portal](https://www.luis.ai/)
* Access to the [VSTS Portal](https://app.vsaex.visualstudio.com), including permissions to create a new repo

---

## Agenda

| From  | To    | Session                                       | Duration |
|-------|-------|-----------------------------------------------|----------|
| 09:30 | 10:00 | Introductions, Agenda Review, Project scoping | 30 mins  |
| 10:00 | 11:00 | Cosmos DB                                     | 1 hour   |
|_11:00_|_11:10_| _Break_                                       |_10 mins_ |
| 11:10 | 12:00 | Functions                                     | 50 mins  |
|_12:00_|_13:00_| _Lunch_                                       |_1 hour_  |
| 13:00 | 14:00 | Logic Apps                                    | 1 hour   |
| 14:00 | 14:45 | Cognitive Services (Azure Search & LUIS)      | 45 mins  |
|_14:45_|_15:00_| _Break_                                       |_15 mins_ |
| 15:00 | 16:00 | Bot Service                                   | 1 hour   |

