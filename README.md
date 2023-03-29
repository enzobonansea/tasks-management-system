# Tasks management system

## Idea

The main goal of this little project is to demonstrate my knowledge in DDD, TDD, Event-Driven Architecture, OOP, .NET, and Docker.

The first feature that I will develop is the creation of a ToDo, a simple entity that has only Title, Description, and Date:

- When ToDo is created, ToDoCreated event is emitted.
- There will be a Scheduler Bounded Context with a handler that reacts to the ToDoCreated event with the command ScheduleToDo.
- When the ToDo date arrives, ToDoDateArrived event will be emitted.
- Several Bounded Context will be able to react to ToDoDateArrived event. For example, a Mailing Bounded Context will be able to react with the command SendEmail.
- Reactions to ToDoDateArrived event will be defined later.

All events will be created in a transaction within its corresponding Aggregate and stored in an outbox table. A supporting bounded context that will be defined is Message Relay Bounded Context, which responsibility will be dispatch the domain events stored in the outbox table.

For simplicity, all the bounded context will be, at first, in the same C# project. They will be virtually separated so splitting the project into many others in such a way that every project has only one bounded context will be straightforward; that's the ideal scenario since this allows independent deployments and independent autoscaling management.

## Done

- ToDo aggregate emitting ToDoCreated event at creation

## Next steps

- Store aggregate in database applying transactional outbox
- Message relay that read the events
