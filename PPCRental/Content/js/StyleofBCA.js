function blurSlide(){
	var slide = document.getElementsByClassName('container slideblur');
	slide[0].style.background='rgba(0, 0, 0, 0.36)';
	slide[0].style.transition='1s';
	slide[0].style.transform ='scale(1.5)';
	slide[1].style.background='rgba(0, 0, 0, 0.36)';
	slide[1].style.transition='1s';
	slide[1].style.transform ='scale(1.5)';
	slide[2].style.background='rgba(0, 0, 0, 0.36)';
	slide[2].style.transition='1s';
	slide[2].style.transform ='scale(1.5)';
	slide[3].style.background='rgba(0, 0, 0, 0.36)';
	slide[3].style.transition='1s';
	slide[3].style.transform ='scale(1.5)';
	slide[4].style.background='rgba(0, 0, 0, 0.36)';
	slide[4].style.transition='1s';
	slide[4	].style.transform ='scale(1.5)';
}
function NotBlur(){
	var slide = document.getElementsByClassName('container slideblur');
	slide[0].style.background='transparent';
	slide[0].style.transition='1s';
	slide[0].style.transform ='scale(1)';
	slide[1].style.background='transparent';
	slide[1].style.transition='1s';
	slide[1].style.transform ='scale(1)';
	slide[2].style.background='transparent';
	slide[2].style.transition='1s';
	slide[2].style.transform ='scale(1)';
	slide[3].style.background='transparent';
	slide[3].style.transition='1s';
	slide[3].style.transform ='scale(1)';
	slide[4].style.background='transparent';
	slide[4].style.transition='1s';
	slide[4].style.transform ='scale(1)';
}