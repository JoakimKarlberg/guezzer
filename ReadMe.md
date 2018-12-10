# Welcome to Guezzer



## Running the Guezzer Vue Client

* Download the [repo](https://github.com/JoakimKarlberg/guezzer/tree/develop) from Github

* Download latest version of [NodeJS](https://nodejs.org/en/)

* Open cmd line and cd to `guezzer` folder in cmd line

* Make sure you have NPM install by typing `npm install` in the `guezzer.Client` folder

* Install Vue.js

	* Install vue-client globally by typing: `npm install -g vue-cli` and press Enter Run

* cd to `guezzer.Client` folder in cmd line

* type `npm run dev` while in the `guezzer.Client` folder to run the frontend application

* Open your browser and go to the localhost adress specified in the cmd line - usually it is [localhost:8080](http://localhost:8080)

## Guezzer.Core

Web API written in ASP.NET Core 2.1.
This project contains all backend stuff.

Uses `EntityFrameWork Core` for database stuff.

## API Requests

### Players

* **GET**: `https://url.com/api/players/` - fetches all players

* **GET**: `https://url.com/api/players/{playerName}` - fetches a specific player

* **PUT**: `https://url.com/api/Players/{playerDto-object}` - updates or create a *Player* if it doesn't exist in the db based on the *Body* of the PUT request. Must match the structure of a *PlayerDto*-object.

### Categories

* **GET**: `https://url.com/api/categories/` - fetches all categories

* **GET**: `https://url.com/api/categories/{categoryName}` - fetches a specific category

### Results

* **GET**: `https://url.com/api/results/` - fetches all results

* **GET**: `https://url.com/api/results/{name}` - fetch all results for a specific player

* **PUT**: `https://url.com/api/Results/{ResultDto-object}` - updates or create a *Result* if it doesn't exist in the db based on the *Body* of the PUT request. Input must match the structure of a *ResultDto*-object.