function test() {
    var cu = document.getElementById('longlon');
    cu.style.width = '500px';
    cu.style.height = '500px';
    cu.style.transition = '2s';
}

function test2() {
    var cu = document.getElementById('longlon');
    cu.style.width = '100px';
    cu.style.height = ('100px');
    cu.style.transition = '2s';
}