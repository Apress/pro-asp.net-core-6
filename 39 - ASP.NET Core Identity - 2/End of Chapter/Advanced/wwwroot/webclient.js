const username = "bob";
const password = "secret";
let token;

window.addEventListener("DOMContentLoaded", () => {
    const controlDiv = document.getElementById("controls");
    createButton(controlDiv, "Get Data", getData);
    createButton(controlDiv, "Log In", login);
    createButton(controlDiv, "Log Out", logout);
});

async function login() {
    let response = await fetch("/api/account/token", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({ username: username, password: password })
    });
    if (response.ok) {
        token = (await response.json()).token;
        displayData("Logged in", token);
    } else {
        displayData(`Error: ${response.status}: ${response.statusText}`);
    }
}

async function logout() {
    token = "";
    displayData("Logged out");
}

async function getData() {
    let response = await fetch("/api/people", {
        headers: { "Authorization": `Bearer ${token}` }
    });
    if (response.ok) {
        let jsonData = await response.json();
        displayData(...jsonData.map(item => `${item.surname}, ${item.firstname}`));
    } else {
        displayData(`Error: ${response.status}: ${response.statusText}`);
    }
}

function displayData(...items) {
    const dataDiv = document.getElementById("data");
    dataDiv.innerHTML = "";
    items.forEach(item => {
        const itemDiv = document.createElement("div");
        itemDiv.innerText = item;
        itemDiv.style.wordWrap = "break-word";
        dataDiv.appendChild(itemDiv);
    })
}

function createButton(parent, label, handler) {
    const button = document.createElement("button");
    button.classList.add("btn", "btn-primary", "m-2");
    button.innerText = label;
    button.onclick = handler;
    parent.appendChild(button);
}
