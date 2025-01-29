// Fake data for the chart
const months = ["Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık"];
const totalOperations = [3300, 3200, 3500, 3600, 4000, 3900, 3700, 3800, 4100, 4200, 4000, 4300];
const unitsData = {
    "Bilgi İşlem": [600, 500, 550, 580, 620, 600, 580, 590, 620, 650, 600, 620],
    "Hizmet": [800, 750, 850, 870, 900, 880, 860, 870, 900, 920, 900, 950],
    "Cenaze": [300, 320, 350, 370, 400, 390, 370, 380, 400, 420, 400, 430],
    "Destek": [900, 850, 950, 970, 1000, 980, 960, 970, 1000, 1020, 1000, 1050],
    "Sosyal Kültürel": [700, 700, 750, 800, 880, 850, 820, 830, 880, 900, 900, 950]
};

const datasets = Object.keys(unitsData).map(unit => ({
    label: unit,
    data: unitsData[unit],
    borderColor: getRandomColor(),
    borderWidth: 2,
    fill: false,
    pointBackgroundColor: getRandomColor()
}));

datasets.push({
    label: 'Toplam İşlem',
    data: totalOperations,
    borderColor: 'black',
    borderWidth: 2,
    pointBackgroundColor: 'black',
    fill: false,
});

const operationsCtx = document.getElementById('operationsChart').getContext('2d');
const operationsChart = new Chart(operationsCtx, {
    type: 'line',
    data: {
        labels: months,
        datasets: datasets
    },
    options: {
        responsive: true,
        plugins: {
            tooltip: {
                callbacks: {
                    label: function (context) {
                        const datasetLabel = context.dataset.label;
                        const index = context.dataIndex;

                        if (datasetLabel === 'Toplam İşlem') {
                            return Object.keys(unitsData).map(unit => `${unit}: ${unitsData[unit][index]}`).join('\n');
                        }

                        return `${datasetLabel}: ${context.raw}`;
                    }
                }
            },
            title: {
                display: true,
                text: 'Yıllık İşlem İstatistikleri',
                font: {
                    size: 18
                }
            }
        },
        scales: {
            x: {
                title: {
                    display: true,
                    text: 'Aylar'
                }
            },
            y: {
                title: {
                    display: true,
                    text: 'İşlem Sayısı'
                }
            }
        }
    }
});

function getRandomColor() {
    const letters = '0123456789ABCDEF';
    let color = '#';
    for (let i = 0; i < 6; i++) {
        color += letters[Math.floor(Math.random() * 16)];
    }
    return color;
}