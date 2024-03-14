window.addEventListener('DOMContentLoaded', function () {
  let otherDate = document.getElementById('otherDateRadio')
  let todayDate = document.getElementById('todayRadio')
  let invoiceDate = document.getElementById('invoiceDate')

  invoiceDate.value = getDateTime()

  otherDate.addEventListener('click', function () {
    if (otherDate.checked == true) {
      invoiceDate.readOnly = false
      console.log(true)
    }
  })

  todayRadio.addEventListener('click', function () {
    if (todayDate.checked == true) {
      console.log(false)
      invoiceDate.value = getDateTime()
      invoiceDate.readOnly = true
    }
  })
})

function getDateTime() {
  var today = new Date();
  var dd = String(today.getDate()).padStart(2, '0');
  var mm = String(today.getMonth() + 1).padStart(2, '0'); //January is 0!
  var yyyy = today.getFullYear();

  today = yyyy + '-' + mm + '-' + dd;
  return today
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
    let loadData = fetch(`/api/Taker/GetTakerData/${takerCi}`)
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