var first = document.getElementById('first');
first.addEventListener("mouseover",ChangBG);
var pwMeo = document.getElementById('pwMeo');
var pass1 = document.getElementById('passNew1');
pass1.addEventListener("input", GetPass);
var sosanh = "";
var meo = "";
function GetPass() {
    sosanh = pass1.value;
    if (sosanh != "" && sosanh == meo) {
        pwMeo.innerText = "";
    } else if (sosanh != "" && sosanh != meo && meo.length > 0) {
        pwMeo.style.color = 'red';
        pwMeo.style.textShadow ='1px 1px 1px white';
        pwMeo.innerText = "Password and Password Confirm Differnt";
    }
}
var pass2 = document.getElementById('passNew2');
pass2.addEventListener("input", GetPass2);

function GetPass2() {
    meo = pass2.value;
    if (meo == sosanh && meo != "") {
        pwMeo.innerText = "";
    } else if (sosanh != "" && sosanh != meo) {
        pwMeo.style.color = 'red';
        pwMeo.style.textShadow = '1px 1px 1px white';
        pwMeo.innerText = "Password and Password Confirm Differnt";
    }
}