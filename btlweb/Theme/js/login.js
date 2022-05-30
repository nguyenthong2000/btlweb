function validator() {
    var email = document.getElementById("tb_username");
    var password = document.getElementById("tb_password");

    if (email.value != '' && password.value != '') {

    } else {
        alert("Bạn cần điền đầy đủ");
    }

}