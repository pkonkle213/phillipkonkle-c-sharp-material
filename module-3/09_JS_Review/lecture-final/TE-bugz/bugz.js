console.log("Hello bugz");

let nextId = 6;

// #1 Declare an array of bugs
const bugs = [
    {
        id: 1,
        description: "Morning arrived too early",
        reporter: "Ben's Brother",
    },
    {
        id: 2,
        description: "Matt asked me questions right after Zoom decided to work",
        reporter: "Not Phil",
    },
    {
        id: 3,
        description: "Excessive cat posteriors and dog snoring",
        reporter: "Caleb and Josh",
    },
    {
        id: 4,
        description: "I make Matt vomit",
        reporter: "Lack of Semicolons",
    },
    {
        id: 5,
        description: "Dogs using wrong beds!",
        reporter: "Josh",
    }
];

function addBugToTable(bugData, tableBody) {
    const tr = document.createElement('tr');

    const tdId = document.createElement('th');
    tdId.innerText = bugData.id;
    tr.appendChild(tdId);

    const tdDesc = document.createElement('td');
    tdDesc.innerText = bugData.description;
    tr.appendChild(tdDesc);

    const tdReporter = document.createElement('td');
    tdReporter.innerText = bugData.reporter;
    tr.appendChild(tdReporter);

    tableBody.appendChild(tr);
}

document.addEventListener('DOMContentLoaded', () => {

    console.log("Cue the DOOM music");

    const tbody = document.querySelector('#bugsTable > tbody')

    // #2 Display all known bugs in the form
    bugs.forEach(bug => {
        addBugToTable(bug, tbody);
    });

    // #3 When the user adds a bug, add it to the form & array
    const form = document.querySelector('form');
    form.addEventListener('submit', event => {
        console.log('Submit clicked!');
        event.preventDefault();

        const newBug = {
            id: nextId++,
            description: document.getElementById('newBugDescription').value,
            reporter: document.getElementById('newBugReportedBy').value,
        };

        console.log(newBug);

        bugs.push(newBug);

        addBugToTable(newBug, tbody);
    });
});

