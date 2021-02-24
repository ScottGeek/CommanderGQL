# CommanderGQL
**Example of using GraphQL and Hot Chocolate**

Nothing really special here. This repo explores using GraphQL with HotChocolate.
  This shows doing Queries, Mutations, and a sample subscription.
  
With this example the main API url is http://localhost:5000/graphql > [!NOTE]
> *Remember that one must do a POST when using GraphQL* (even when doing a GET)

Voyager 


examples:

Queries:

 -Plain get some data
```sql

  query{
  commands{
    id
    howTo
    commandLine
    platform{
      name
    }
  }
}
```
-Doing some sorting
```sql
query {
  platform(order: {name: DESC})
  {
    name
  }
}
```
-Doing a filter
```sql
query{
  commands(where: {platformId: {eq: 1}} ){
    id
    howTo
    commandLine
    platform{
      name
      id
    }
  }
}
```

Mutations (adding data to the Db):
```sql
mutation{
  addPlatform(input:
  { name: "GitHub"
  })
  {
    platform
    {
      id
      name
    }
  }
}
```    
