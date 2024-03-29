window.onload = function () {
  getMonthInvoices();
  getTotalIncome();
};

function setTotalIncomeValue() {
  document.getElementById("totalIncome2").innerHTML = "I love God and Jesus!";
}

function getTotalIncome() {
  fetch("/api/Invoices/GetProviderTotalIncome")
    .then((res) => res.json())
    .then(function (data) {
      document.getElementById("totalIncome").innerHTML = `$${data.toFixed(2)}`;
    });
}

function getMonthInvoices() {
  google.charts.load("current", {
    packages: ["corechart"],
  });
  google.charts.setOnLoadCallback(drawChart);

  function drawChart() {
    fetch("/api/Invoices/GetProviderInvoiceHistory")
      .then((res) => res.json())
      .then(function (data) {
        var data = google.visualization.arrayToDataTable([
          ["Month", "Invoices"],
          ["Jan", data[0]],
          ["Fev", data[1]],
          ["Mar", data[2]],
          ["Apr", data[3]],
          ["May", data[4]],
          ["Jun", data[5]],
          ["Jul", data[6]],
          ["Aug", data[7]],
          ["Sep", data[8]],
          ["Oct", data[9]],
          ["Nov", data[10]],
          ["Dec", data[11]],
        ]);

        var options = {
          title: "Company Yearly Invoices",
          hAxis: {
            title: "Year",
            titleTextStyle: {
              color: "#333",
            },
          },
          vAxis: {
            minValue: 0,
          },
          width: "100%",
        };

        var chart = new google.visualization.AreaChart(
          document.getElementById("chart_div")
        );
        chart.draw(data, options);
      });
  }
}
