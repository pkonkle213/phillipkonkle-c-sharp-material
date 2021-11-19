console.log('Reading app.js file...');

let thingsMattThinksAreFun = [
    {name: 'Intro to C# & .NET', week: 1},
    {name: 'Classes', week: 2},
    {name: 'Polymorphism',week: 3},
    {name: 'Abstract Classes', week: 3},
    {name: 'Exceptions', week: 4},
    {name: 'Code Reviews', week: 5},
    {name: 'REST APIs', week: 7},
    {name: 'ASP .NET Core', week: 7},
    {name: 'JWT Authentication', week: 8},
    {name: 'CSS Grid', week: 9},
    {name: 'Mock Technicals', week: 9},
    {name: 'JavaScript', week: 10},
    {name: 'Arrow Functions', week: 10},
    {name: 'Vue.js', week: 11},
    {name: 'Vuex', week: 11},
    {name: 'Axios', week: 12},
    {name: 'Final Capstones', week: 13},
    {name: 'Seeing Students get Jobs'},
    {name: 'Hearing from Graduates'},
];

function getModuleNumFromWeekNum(weekNum) {
    switch (weekNum)
    {
        case 1:
        case 2:
        case 3:
        case 4:
            return 1;
        case 5:
        case 6:
        case 7:
        case 8:
            return 2;
        case 9:
        case 10:
        case 11:
        case 12:
            return 3;
        default:
            return '???';
    }
}

document.addEventListener('PageLoaded', () => {
    console.log('Application Starting...');

    // Add a module number to each thing Matt thinks is fun
    thingsMattThinksAreFun = thingsMattThinksAreFun.map(thing => {
        let newThing = {
            name: thing.name, 
            week: thing.week,
            module: getModuleNumFromWeekNum(thing.weekNum) 
        };

        console.debug('Mapping', thing, newThing);
    });

    console.log('Value of data after the map', thingsMattThinksAreFun);

    // For each thing Matt thinks is fun, add an H2 element for it to the DOM
    let app = document.getElementById('#app');
    thingsMattThinksAreFun.forEach(thing => {
        // Add a header
        let header = document.createElement('h2');
        header.innerText = thing.name;
        app.appendChild(header);

        // Add the paragraph for it
        let para = document.createElement('p');
        if (thing.week) {
            para.innerText = `Module ${thing.module}, Week ${thing.week}`;
        } else {
            para.innerText = 'No fixed date';
        }
        app.appendChild(para);
    });
});