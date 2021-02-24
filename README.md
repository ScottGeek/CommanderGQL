# CommanderGQL
Example of using GraphQL and Hot Chocolate 

Nothing really special here. This repo explores using GraphQL with HotChocolate.
  This shows doing Queries, Mutations, and a sample subscription.
  
With this example the main API url is http://localhost:5000/graphql *Remember that one must do a POST when using GraphQL* (even when doing a GET)

examples:
  Queries:
  
  -Plain get some data
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

-Doing some sorting

query {
  platform(order: {name: DESC})
  {
    name
  }
}

-Doing a filter

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


Mutations (adding data to the Db):

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



    
