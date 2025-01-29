document.getElementById('taskForm').addEventListener('submit', function (event) {
    event.preventDefault();

    // Formdan verileri al
    const personel = document.getElementById('personel').value;
    const gorev = document.getElementById('gorev').value;

    // Yeni görev öğesi oluştur
    const taskItem = document.createElement('li');
    taskItem.textContent = `${personel} - ${gorev}`;
    taskItem.classList.add('not-completed');

    // Görev durumunu değiştirmek için tıklama olayı ekle
    taskItem.addEventListener('click', function () {
        if (taskItem.classList.contains('completed')) {
            taskItem.classList.remove('completed');
            taskItem.classList.add('not-completed');
        } else {
            taskItem.classList.remove('not-completed');
            taskItem.classList.add('completed');
        }
    });

    // Görev listesine ekle
    document.getElementById('taskList').appendChild(taskItem);

    // Formu temizle
    document.getElementById('taskForm').reset();
});