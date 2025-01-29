// Veriler
const years = ['2020', '2021', '2022', '2023', '2024'];
const beyazYaka = [450, 579, 579, 749, 850];
const maviYaka = [1850, 2371, 2371, 2749, 2835];
const toplam = beyazYaka.map((b, i) => b + maviYaka[i]);


// Chart.js grafiği
const ctx = document.getElementById('personelChart').getContext('2d');
new Chart(ctx, {
    type: 'line',
    data: {
        labels: years, // X ekseni
        datasets: [
            {
                label: 'Beyaz Yaka',
                data: beyazYaka,
                borderColor: 'rgba(75, 192, 192, 1)',
                backgroundColor: 'rgba(75, 192, 192, 0.2)',
                borderWidth: 2,
                tension: 0.4,
                pointStyle: 'circle',
                pointRadius: 5,
                pointHoverRadius: 7,
            },
            {
                label: 'Mavi Yaka',
                data: maviYaka,
                borderColor: 'rgba(255, 159, 64, 1)',
                backgroundColor: 'rgba(255, 159, 64, 0.2)',
                borderWidth: 2,
                tension: 0.4,
                pointStyle: 'circle',
                pointRadius: 5,
                pointHoverRadius: 7,
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
                        const toplamPersonel = toplam[index];
                        const beyaz = beyazYaka[index];
                        const mavi = maviYaka[index];
                        return [
                            `Beyaz Yaka: ${beyaz}`,
                            `Mavi Yaka: ${mavi}`,
                            `Toplam: ${toplamPersonel}`,
                        ];
                    }
                }
            },
            legend: {
                display: true,
                position: 'top'
            }
        },
        scales: {
            x: {
                title: {
                    display: true,
                    text: 'Yıllar',
                    font: {
                        size: 14,
                    }
                }
            },
            y: {
                title: {
                    display: true,
                    text: 'Personel Sayısı',
                    font: {
                        size: 14,
                    }
                },
                beginAtZero: true
            }
        }
    }
});
