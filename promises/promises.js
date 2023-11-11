// add/remove the _RENAME suffix to force the error
const players_RENAME = [];

const players = [
    {
        firstName: "Damián",
        middleName: "Emiliano",
        lastName: "Martínez",
        dateOfBirth: "1992-09-02T00:00:00.000Z",
        squadNumber: 23,
        position: "Goalkeeper",
        abbrPosition: "GK",
        team: "Aston Villa FC",
        league: "Premier League",
        starting11: true,
    },
    {
        firstName: "Nahuel",
        middleName: "",
        lastName: "Molina",
        dateOfBirth: "1998-04-06T00:00:00.000Z",
        squadNumber: 26,
        position: "Right-Back",
        abbrPosition: "RB",
        team: "Atlético Madrid",
        league: "La Liga",
        starting11: true,
    },
    {
        firstName: "Cristian",
        middleName: "Gabriel",
        lastName: "Romero",
        dateOfBirth: "1998-04-27T00:00:00.000Z",
        squadNumber: 13,
        position: "Centre-Back",
        abbrPosition: "CB",
        team: "Tottenham Hotspur",
        league: "Premier League",
        starting11: true,
    },
    {
        firstName: "Nicolás",
        middleName: "Hernán Gonzalo",
        lastName: "Otamendi",
        dateOfBirth: "1988-02-12T00:00:00.000Z",
        squadNumber: 19,
        position: "Centre-Back",
        abbrPosition: "CB",
        team: "SL Benfica",
        league: "Liga Portugal",
        starting11: true,
    },
    {
        firstName: "Nicolás",
        middleName: "Alejandro",
        lastName: "Tagliafico",
        dateOfBirth: "1992-08-31T00:00:00.000Z",
        squadNumber: 3,
        position: "Left-Back",
        abbrPosition: "LB",
        team: "Olympique Lyon",
        league: "Ligue 1",
        starting11: true,
    },
    {
        firstName: "Ángel",
        middleName: "Fabián",
        lastName: "Di María",
        dateOfBirth: "1988-02-14T00:00:00.000Z",
        squadNumber: 11,
        position: "Right Winger",
        abbrPosition: "LW",
        team: "SL Benfica",
        league: "Liga Portugal",
        starting11: true,
    },
    {
        firstName: "Rodrigo",
        middleName: "Javier",
        lastName: "de Paul",
        dateOfBirth: "1994-05-24T00:00:00.000Z",
        squadNumber: 7,
        position: "Central Midfield",
        abbrPosition: "CM",
        team: "Atlético Madrid",
        league: "La Liga",
        starting11: true,
    },
    {
        firstName: "Enzo",
        middleName: "Jeremías",
        lastName: "Fernández",
        dateOfBirth: "2001-01-17T00:00:00.000Z",
        squadNumber: 24,
        position: "Central Midfield",
        abbrPosition: "CM",
        team: "Chelsea FC",
        league: "Premier League",
        starting11: true,
    },
    {
        firstName: "Alexis",
        middleName: "",
        lastName: "Mac Allister",
        dateOfBirth: "1998-12-24T00:00:00.000Z",
        squadNumber: 20,
        position: "Central Midfield",
        abbrPosition: "CM",
        team: "Liverpool FC",
        league: "Premier League",
        starting11: true,
    },
    {
        firstName: "Lionel",
        middleName: "Andrés",
        lastName: "Messi",
        dateOfBirth: "1987-06-24T00:00:00.000Z",
        squadNumber: 10,
        position: "Right Winger",
        abbrPosition: "RW",
        team: "Inter Miami CF",
        league: "Major League Soccer",
        starting11: true,
    },
    {
        firstName: "Julián",
        middleName: "",
        lastName: "Álvarez",
        dateOfBirth: "2000-01-31T00:00:00.000Z",
        squadNumber: 9,
        position: "Centre-Forward",
        abbrPosition: "CF",
        team: "Manchester City",
        league: "Premier League",
        starting11: true,
    },
];

const getPlayers = () => {
    return new Promise((resolve, reject) => {
        // reject
        if (players.length === 0) {
            reject(new Error('No Content'));
        }
        // resolve
        setTimeout(() => {
            resolve(players);
        }, 3000); // 3 sec delay
    });
}
// ECMAScript 6 (ES6) "then" syntax
// getPlayers()
//     .then((team) => console.log(team));
//     .catch(error => console.log(error));

// ECMAScript 8 (ES8) "async/await" syntax
async function getTeam() {
    try {
        const team = await getPlayers();
        return JSON.stringify(team, null, 4);
    } catch (error) {
        console.error(error.message);
    }
};
