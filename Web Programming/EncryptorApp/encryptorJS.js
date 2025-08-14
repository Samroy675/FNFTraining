
function mapWords() {
    let words = ["the", "quick", "brown", "fox", "jumps", "over", "lazy", "dog"];
    const item = new Map([
        ["t", 0], ["h", 0], ["e", 0],
        ["q", 1], ["u", 1], ["i", 1], ["c", 1], ["k", 1],
        ["b", 2], ["r", 2], ["o", 2], ["w", 2], ["n", 2],
        ["f", 3], ["x", 3],
        ["j", 4], ["m", 4], ["p", 4], ["s", 4],
        ["v", 5], ["e", 5], ["r", 5], ["o", 5],
        ["l", 6], ["a", 6], ["z", 6], ["y", 6],
        ["d", 7], ["g", 7], ["o", 7]
    ]);

    let name = document.getElementById("nameInput").value.toLowerCase();
    let result = "";

    for (let i = 0; i < name.length; i++) {
        let char = name[i];
        if (char === " ") {
            result += "-"; // Replace space with hyphen
        } else if (item.has(char)) {
            let wordIndex = item.get(char);
            let word = words[wordIndex];
            let charIndex = word.indexOf(char);
            result += `${wordIndex}${charIndex}`;
        }
    }

    document.getElementById("result").textContent = `Encrypted Output: ${result}`;
}

document.getElementById("encryptBtn").addEventListener("click", mapWords);
