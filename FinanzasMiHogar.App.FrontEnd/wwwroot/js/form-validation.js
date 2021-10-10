// Example starter JavaScript for disabling form submissions if there are invalid fields
(function () {
  'use strict'

  // Fetch all the forms we want to apply custom Bootstrap validation styles to
  var forms = document.querySelectorAll('.needs-validation')

  // Loop over them and prevent submission
  Array.prototype.slice.call(forms)
    .forEach(function (form) {
      form.addEventListener('submit', function (event) {
        if (!form.checkValidity()) {
          event.preventDefault()
          event.stopPropagation()
        }

        form.classList.add('was-validated')
      }, false)
    })
})()
function verificarContraseña() {
  password1 = document.getElementById('password1');
  password2 =document.getElementById('password2');
  if (password1.value != password2.value) {
    document.getElementById('error').classList.add("mostrar")
    return false;
  }else{
    document.getElementById("error").classList.remove("mostrar")    
    return true;
  }
}
