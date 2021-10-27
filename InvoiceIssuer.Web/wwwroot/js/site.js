$(window).on('load', function () {
	$('#modal').modal('show');
});

getMonthInvoices()
getTotalIncome()

function getTotalIncome(){
	fetch('/Invoices/GetProviderTotalIncome')
		.then(res => res.json())
		.then(function (data){
			for(let i=0; i<=data; i++){
				setTimeout(function(){
					document.getElementById('totalIncome').innerHTML = i.toFixed(2)
				}, 50)
			}
			clearInterval()
		})
}

function getMonthInvoices() {
	google.charts.load('current', {
		'packages': ['corechart']
	});
	google.charts.setOnLoadCallback(drawChart);

	function drawChart() {
		fetch('/Invoices/GetProviderInvoiceHistory')
			.then(res => res.json())
			.then(function (data) {
				console.log(data)
				var data = google.visualization.arrayToDataTable([
					['Month', 'Invoices'],
					['Jan', data[0]],
					['Fev', data[1]],
					['Mar', data[2]],
					['Apr', data[3]],
					['May', data[4]],
					['Jun', data[5]],
					['Jul', data[6]],
					['Aug', data[7]],
					['Sep', data[8]],
					['Oct', data[9]],
					['Nov', data[10]],
					['Dec', data[11]],
				]);

				var options = {
					title: 'Company Yearly Invoices',
					hAxis: {
						title: 'Year',
						titleTextStyle: {
							color: '#333'
						}
					},
					vAxis: {
						minValue: 0,
					},
					width: '100%',
				};

				var chart = new google.visualization.AreaChart(document.getElementById('chart_div'));
				chart.draw(data, options);
			})
	}
}

function getTakerData() {
	const takerCi = document.getElementById('ci').value;

	if (takerCi == " " || undefined || takerCi.length < 7) {
		document.getElementById('invoiceWarnings').innerHTML =
			` 
      <div  class="alert alert-danger p-2 text-center">
        <h6>Please insert a valid CI!</h6>
      </div>
    `

	} else {
		let loadData = fetch(`/Invoices/GetTakerData/${takerCi}`)
			.then(res => res.json())
			.then(function (data) {
				document.getElementById('invoiceWarnings').innerHTML = " "
				document.getElementById('comercialName').value = data['comercialName']
				document.getElementById('phone').value = data['phone']
				document.getElementById('takerEmail').value = data['email']
				document.getElementById('road').value = data['address']['road']
				document.getElementById('roadNumber').value = data['address']['number']
				document.getElementById('complement').value = data['address']['complement']
				document.getElementById('block').value = data['address']['block']
				document.getElementById('city').value = data['address']['city']
				document.getElementById('state').value = data['address']['state']
				document.getElementById('postalCode').value = data['address']['postalCode']
				document.getElementById('companySelect').value = data['companyType']['name']
			}).catch(function () {
				document.getElementById('invoiceWarnings').innerHTML =
					` 
          <div  class="alert alert-warning p-2 text-center">
            <h6>No company was found with given CI!</h6>
          </div>
        `
				document.getElementById('ci').value = " ";
				document.getElementById('comercialName').value = " "
				document.getElementById('phone').value = " "
				document.getElementById('takerEmail').value = " "
				document.getElementById('road').value = " "
				document.getElementById('roadNumber').value = " "
				document.getElementById('complement').value = " "
				document.getElementById('block').value = " "
				document.getElementById('city').value = " "
				document.getElementById('state').value = " "
				document.getElementById('postalCode').value = " "
				document.getElementById('companySelect').value = " "
			})
	}
}