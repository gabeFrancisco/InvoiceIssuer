$(window).on('load', function () {
  $('#modal').modal('show');
});

function getTakerData() {
  const takerCi = document.getElementById('ci').value;

  if (takerCi == " " || undefined || takerCi.length < 7) {
    alert("Please insert a valid CI")

  } else {
    let loadData = fetch(`/Invoices/GetTakerData/${takerCi}`)
      .then(res => res.json())
      .then(function (data) {
        console.log(data)
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
        }
      )
  }
}