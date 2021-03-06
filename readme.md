# Pokemon API #

## About ##

http://pokeapi.azurewebsites.net/

An Api made in .NET core 3.x related to Pokemon. Get, add delete Pokémon.

A folder in the www root containing a certain amount of JSON files where each file represents a Pokémon. Each file is loaded into an SQL-Lite In-memory database at startup, to which the requests are made.
___

## Getting Started
How to setup project on your own machine.
### Prerequisites
```
Dotnet core 3.1 https://dotnet.microsoft.com/download/dotnet-core/3.1
Visual Studio 2019: https://visualstudio.microsoft.com/downloads/ or other IDE/editor of choice.
```
___

### List Pokemon

Retrieve a list of pokemon.

Parameters are sent as query parameters.

#### `GET` /api/pokemon/list

| Parameter    | Value                        | Required | Example   |
| ------------ | ---------------------------- | -------- | --------- |
| `Sort`       | `{propertyName} {direction}` |          | name desc |
| `PageSize`   | `{number}`                   |          | 10        |
| `PageNumber` | `{number}`                   |          | 1         |

___
### Get Pokemon

Retrieve a single pokemon.

#### `GET` `/api/pokemon/{pokemonname}`

| Parameter | Value    | Required | Example           |
| --------- | -------- | -------- | ----------------- |
| `Name`      | `{string}` | ✅        | Bulbasaur |
___

### Add Pokemon

Add a single pokemon.

Parameters are sent as JSON from body.

#### `POST` `api/pokemon/add`

| Parameter | Value    | Required | Example           |
| --------- | -------- | -------- | ----------------- |
| `index`      | `{string}` |         | 719 |
| `name`      | `{string}` | ✅        | Bulbasaur |
| `imageUrl`      | `{string}` | ✅        | http://serebii.net/xy/pokemon/001.png|
| `types`      | `{array}` |         | "types": ["grass","poison"] |
| `evolutions`      | `{array}`of`{object`} |         | ▼ |
| `moves`      | `{array}`of`{object`} |         | ▼ |
  ```javascript
"evolutions": [
      {
          "pokemon":2,
          "event":"level-16"
      }
  ],
  
"moves": [
    {
      "level": "37",
      "name": "Seed Bomb",
      "type": "grass",
      "category": "physical",
      "attack": "80",
      "accuracy": "100",
      "pp": "15",
      "effect_percent": "--",
      "description": "The user slams a barrage of hard-shelled seeds down on the target from above."
    }
  ]
  ```

___
### Delete Pokemon

Delete a single pokemon.

#### `DELETE` `/api/pokemon/{pokemonname}`

| Parameter | Value    | Required | Example           |
| --------- | -------- | -------- | ----------------- |
| `Name`      | `{string}` | ✅        | Bulbasaur |
___


## Requirements
```
Dotnet core 3.1 SDK and the runtime: https://dotnet.microsoft.com/download/dotnet-core/3.1
Visual Studio 2019: https://visualstudio.microsoft.com/downloads/
```

Use previews of the .NET Core SDK In Visual Studio 2019
1. Tools
2. Options
3. Projects and Solutions
4. .NET Core
5. Check "Use previews of the .NET Core SDK"

___

### TODO:

- [x] Update to Core 3.
- [ ] Use nullable reference types.
- [x] Correctly load the collections of Pokemon with Entity Framework (Evolutions and Moves).
- [ ] Refractor.
- [x] Add Pokémon endpoint
- [x] Delete Pokémon endpoint
- [x] Logging
- [x] Custom exception handling (return generic api response)
- [ ] Add authorization/jwt tokens
- [ ] Add caching
- [x] Validation failure should return generic api response
- [x] Adding a Pokemon should return generic api response
