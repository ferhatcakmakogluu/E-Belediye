// Elementleri seçme
const messagesContainer = document.getElementById('messages');
const messageInput = document.getElementById('messageInput');
const sendButton = document.getElementById('sendButton');
const inboxList = document.getElementById('inbox');
const messageHeader = document.getElementById('messageHeader');

// Mesaj gönderme fonksiyonu
function sendMessage() {
    const messageText = messageInput.value.trim();
    if (messageText === "") return;

    // Yeni mesaj oluştur
    const messageElement = document.createElement('div');
    messageElement.classList.add('message', 'sent');
    messageElement.innerHTML = `
    <p>${messageText}</p>
    <span class="time">${new Date().toLocaleTimeString([], { hour: '2-digit', minute: '2-digit' })}</span>
  `;

    // Mesajı ekle
    messagesContainer.appendChild(messageElement);
    messageInput.value = "";

    // Mesaj kutusunu en altına kaydır
    messagesContainer.scrollTop = messagesContainer.scrollHeight;
}

// Gönder butonuna tıklama olayı
sendButton.addEventListener('click', sendMessage);

// Enter tuşu ile mesaj gönderme
messageInput.addEventListener('keypress', function (e) {
    if (e.key === 'Enter') {
        sendMessage();
    }
});

// Tablodaki satırlara tıklama olayı
const tableRows = document.querySelectorAll('.inbox-list tbody tr');

tableRows.forEach(row => {
    row.addEventListener('click', () => {
        const messageText = row.getAttribute('data-message');
        const senderName = row.querySelector('td:nth-child(2)').textContent;

        // Tıklanan satıra active class'ını ekle
        tableRows.forEach(tr => tr.classList.remove('active'));
        row.classList.add('active');

        if (row.classList.contains("unreaded")) {
            row.classList.remove("unreaded")
        }

        // Mesaj kutusunu temizle
        messagesContainer.innerHTML = '';

        // Başlık güncelle
        messageHeader.textContent = `Sohbet: ${senderName}`;

        // Yeni mesajı ekle
        const messageElement = document.createElement('div');
        messageElement.classList.add('message', 'received');
        messageElement.innerHTML = `
      <p>${messageText}</p>
      <span class="time">${new Date().toLocaleTimeString([], { hour: '2-digit', minute: '2-digit' })}</span>
    `;

        messagesContainer.appendChild(messageElement);
    });
});