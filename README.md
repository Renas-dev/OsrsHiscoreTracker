# OSRS Hiscore Tracker (C# + PostgreSQL)

## Overview

This repository contains a C# application built to practice real-world backend fundamentals by integrating with the official Old School RuneScape Ironman Hiscore API and storing historical data in PostgreSQL.

The project retrieves player data via HTTP, stores structured snapshots in a PostgreSQL database, and enables comparison and progress tracking over time.

The goal is to understand the complete data flow:

HTTP Request → Parsing → Persistence → Retrieval → Comparison

---

## Primary Goals

### Goal 1 — Official OSRS Ironman API Integration

- Use the official OSRS Ironman Hiscores Lite endpoint  
- Perform HTTP GET requests using `HttpClient`
- Handle network failures and HTTP status codes
- Parse structured CSV-style responses
- Display structured output in the console

Official OSRS Ironman endpoint used in this project:

http://services.runescape.com/m=hiscore_oldschool_ironman/index_lite.ws?player=<USERNAME>

The username must be URL-encoded to support spaces and special characters.

---

### Goal 2 — PostgreSQL Storage & Snapshot Comparison

- Store player snapshots in a locally hosted PostgreSQL database
- Persist skill statistics per snapshot
- Retrieve historical data
- Compare snapshots to calculate XP gains and progression over time

Both goals are implemented within the same repository to simulate a real backend workflow.

---

## Learning Objectives

By completing this project, I practice and deepen my understanding of:

- Making HTTP requests using `HttpClient`
- Async / await and task-based programming
- Handling HTTP status codes and network failures
- Parsing structured text (CSV-style API responses)
- Designing clean method and class separation
- Connecting to PostgreSQL using Npgsql
- Database schema design and relational modeling
- Persisting and retrieving structured data
- Comparing historical datasets
- Writing maintainable backend-style C# code

---

## Technology Stack

- C# (.NET)
- HttpClient
- PostgreSQL (locally hosted, no Docker)
- Npgsql (PostgreSQL driver for .NET)

---

## Project Scope

The application will:

1. Ask the user for an OSRS username
2. URL-encode the username
3. Call the official Ironman hiscore endpoint
4. Parse the raw API response into structured objects
5. Store a timestamped snapshot in PostgreSQL
6. Retrieve previous snapshots
7. Compare XP differences between snapshots
8. Display progress results in the console

The scope evolves in phases to reinforce learning step-by-step.

---

## Architecture Approach

The project follows a simple layered structure:

- Program Flow (Console UI)
- HTTP Client Layer
- Parsing Layer
- Domain Models
- PostgreSQL Data Layer
- Comparison Logic

The focus is clarity and separation of responsibilities rather than overengineering.

---

## Implementation Phases

### Phase 1 — HTTP Integration

- Prompt user for username
- URL encode input
- Perform HTTP GET request
- Handle non-success responses
- Parse raw hiscore response
- Print selected stats in console

Goal: Build reliable API integration.

---

### Phase 2 — PostgreSQL Integration

- Install and run PostgreSQL locally
- Create relational tables for:
  - Players
  - Snapshots (timestamped)
  - SkillStats (linked to snapshot)
- Store parsed hiscore data
- Retrieve previously stored snapshots

Goal: Learn relational schema design and data persistence.

---

### Phase 3 — Data Comparison

- Load multiple snapshots
- Compare XP differences
- Calculate XP gain per skill
- Print comparison summary in console

Goal: Apply analytical logic to stored data.

---

## Core Concepts Practiced

- HTTP communication
- Asynchronous programming
- Structured data parsing
- PostgreSQL integration
- Schema design
- Data persistence
- Clean code structure
- Error handling and resilience
- Incremental feature development

---

## Example Features (Planned)

- Display total level and combat stats
- Track XP gains between sessions
- Compare two players
- Show boss kill count changes
- Export summary reports
- Add support for other hiscore modes (Hardcore / Ultimate)

---

## Completion Criteria

This project is considered complete when:

- HTTP requests work reliably
- API responses are parsed correctly
- Data is stored in PostgreSQL
- Snapshots can be retrieved
- XP differences can be calculated accurately
- The codebase is logically structured and readable

---

## Notes

This is a learning-focused project intended to build practical backend experience.

The database is hosted locally without Docker to practice native PostgreSQL setup and configuration.

This project is not affiliated with Jagex or Old School RuneScape.
