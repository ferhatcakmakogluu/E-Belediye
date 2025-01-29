// Fake data for the chart
const years = ["2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024"];
const personnelCounts = [50, 65, 80, 90, 120, 140, 155, 160, 170, 190];
const blueCollarCounts = [20, 25, 30, 35, 40, 50, 60, 65, 70, 80];
const whiteCollarCounts = [30, 40, 50, 55, 80, 90, 95, 95, 100, 110];
const details = [
    { male: 30, female: 20, avgAge: 35, blueCollar: 20, whiteCollar: 30 },
    { male: 40, female: 25, avgAge: 36, blueCollar: 25, whiteCollar: 40 },
    { male: 50, female: 30, avgAge: 34, blueCollar: 30, whiteCollar: 50 },
    { male: 55, female: 35, avgAge: 33, blueCollar: 35, whiteCollar: 55 },
    { male: 70, female: 50, avgAge: 32, blueCollar: 40, whiteCollar: 80 },
    { male: 75, female: 65, avgAge: 34, blueCollar: 50, whiteCollar: 90 },
    { male: 80, female: 75, avgAge: 35, blueCollar: 60, whiteCollar: 95 },
    { male: 85, female: 75, avgAge: 36, blueCollar: 65, whiteCollar: 95 },
    { male: 90, female: 80, avgAge: 37, blueCollar: 70, whiteCollar: 100 },
    { male: 100, female: 90, avgAge: 38, blueCollar: 80, whiteCollar: 110 },
];

const ctx = document.getElementById('personelChart').getContext('2d');
const personelChart = new Chart(ctx, {
    type: 'line',
    data: {
        labels: years,
        datasets: [
            {
                label: 'Personel Sayısı',
                data: personnelCounts,
                borderColor: 'blue',
                backgroundColor: 'rgba(0, 123, 255, 0.2)',
                borderWidth: 2,
                pointBackgroundColor: 'blue',
            },
            {
                label: 'Mavi Yaka',
                data: blueCollarCounts,
                borderColor: 'green',
                backgroundColor: 'rgba(0, 255, 0, 0.2)',
                borderWidth: 2,
                pointBackgroundColor: 'green',
            },
            {
                label: 'Beyaz Yaka',
                data: whiteCollarCounts,
                borderColor: 'red',
                backgroundColor: 'rgba(255, 0, 0, 0.2)',
                borderWidth: 2,
                pointBackgroundColor: 'red',
            }
        ]
    },
    options: {
        responsive: true,
        plugins: {
            tooltip: {
                callbacks: {
                    label: function (context) {
                        const index = context.dataIndex;
                        const detail = details[index];
                        return [
                            `Erkek: ${detail.male}`,
                            `Kadın: ${detail.female}`,
                            `Ortalama Yaş: ${detail.avgAge}`,
                            `Mavi Yaka: ${detail.blueCollar}`,
                            `Beyaz Yaka: ${detail.whiteCollar}`
                        ];
                    }
                }
            },
            title: {
                display: true,
                text: 'Personel İstatistikleri',
                font: {
                    size: 18
                }
            }
        },
        scales: {
            x: {
                title: {
                    display: true,
                    text: 'Yıllar'
                }
            },
            y: {
                title: {
                    display: true,
                    text: 'Personel Sayısı'
                }
            }
        }
    }
});