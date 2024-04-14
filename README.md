# World Of Gamecraft

## How to run
From the root of the project run the command:
```
docker-compose -up
```
This will spin up all the necessary services: Account Service, Character Service, databases, and Redis for caching.

## How to test
You can use the postman collection provided to test the services.

## Notes
### Race condition
There's a race condition for *grant* and *gift* items. 
It is handled with optimistic concurrency without the need for locking since this scenario won't occur often.

### Testing
It is shown in one example of how testing is done. Due to time limitations, all methods could not be tested.
