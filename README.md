# CommanderGQL
**Example of using GraphQL and Hot Chocolate**

Nothing really special here. This repo explores using GraphQL with HotChocolate.
  This shows doing Queries, Mutations, and a sample subscription.
  
With this example the main API url is http://localhost:5000/graphql > 
> *Remember that one must do a POST when using GraphQL* (even when doing a GET)

Voyager 
 The Voyager Data Diagram accessed from: http://localhost:5000/graphql-voyager when the App is running

![Image of Voyager Generated Page](Docs/Images/screenshot-localhost-5000-graphql-voyager-1614195588800.png)

This web inteface will allow one walk the data models in the code and see relationships for Queries, Mutations, etc.

To test the API, one should really try Insomnia https://insomnia.rest/. This API tester appears to have a good interface for running API endpoints.

**Some GraphQL Examples:**

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

Enjoy 😎  ~ScottGeek