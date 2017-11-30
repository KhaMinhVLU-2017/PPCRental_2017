var first = document.getElementById('first');
first.addEventListener("mouseover",ChangBG);
function ChangBG(){
	var body = document.getElementsByTagName('body')[0];
	body.style.backgroundImage='url("/Content/img/img_changepass/bg3.jpg")';
	body.style.height='100vh';
	body.style.backgroundPosition='center';
	body.style.size='cover';
	body.style.transition='1s';
}
first.addEventListener("mouseout",ChangBGout);
function ChangBGout(){
	var body = document.getElementsByTagName('body')[0];
    body.style.backgroundImage ='url("/Content/img/img_changepass/bg.jpg")';
	body.style.height='100vh';
	body.style.backgroundPosition='center'; 
	body.style.size='cover';
	body.style.transition='1s';
}