const telefoneInput = document.getElementById('telefone');
telefoneInput.addEventListener('input', function () {
    const telefoneValue = telefoneInput.value;
    const telefoneRegex = /^\d{10}$/;
    if (!telefoneRegex.test(telefoneValue)) {
        telefoneInput.setCustomValidity('Insira um número de telefone válido com 10 dígitos.');
    } 
    else {
        telefoneInput.setCustomValidity('');
    }
});



document.querySelector('form').addEventListener('submit', function (e) {
    const nomeInput = document.getElementById('nome');
    const enderecoInput = document.getElementById('endereco');
    const telefoneInput = document.getElementById('telefone');
    const tamanhoInputs = document.querySelectorAll('input[name="tamanho"]');
    const pagamentoInputs = document.querySelectorAll('input[name="pagamento"]');

    if (!nomeInput.value) {
        e.preventDefault();
        document.getElementById('nomeError').textContent = 'Campo Nome é obrigatório.';
    }

    if (!enderecoInput.value) {
        e.preventDefault();
        document.getElementById('enderecoError').textContent = 'Campo Endereço é obrigatório.';
    }

    if (!telefoneInput.value) {
        e.preventDefault();
        document.getElementById('telefoneError').textContent = 'Campo Telefone é obrigatório.';
    }

    let tamanhoSelecionado = false;
    tamanhoInputs.forEach(input => {
        if (input.checked) {
            tamanhoSelecionado = true;
        }
    });

    if (!tamanhoSelecionado) {
        e.preventDefault();
        document.getElementById('tamanhoError').textContent = 'Selecione um tamanho.';
    }

    let pagamentoSelecionado = false;
    pagamentoInputs.forEach(input => {
        if (input.checked) {
            pagamentoSelecionado = true;
        }
    });

    if (!pagamentoSelecionado) {
        e.preventDefault();
        document.getElementById('pagamentoError').textContent = 'Selecione uma forma de pagamento.';
    }
});



var slideIndex = 1;
var slideIndex2 = 0;

showSlidesAutomatic();

function plusSlides(n) {
    showSlides(slideIndex += n)
}

function currentSlide(n) {
    showSlides(slideIndex = n)
}

function showSlides(n) {
    var i;
    var slides = document.getElementsByClassName("mySlides");
    var dots = document.getElementsByClassName("dot");

    if (n > slides.length) { slideIndex = 1 }
    if (n < 1) { slideIndex = slides.length }

    for (i = 0; i < slides.length; i++) {
        slides[i].style.display = "none";
    }

    for (i = 0; i < dots.length; i++) {
        dots[i].className = dots[i].className.replace(" active", "")
    }

    slides[slideIndex - 1].style.display = "block";
    dots[slideIndex - 1].className += " active";
}

function showSlidesAutomatic() {
    var i;
    var slides = document.getElementsByClassName("mySlides");
    var dots = document.getElementsByClassName("dot");

    for (i = 0; i < slides.length; i++) {
        slides[i].style.display = "none";
    }

    slideIndex2++;

    if (slideIndex2 > slides.length) { slideIndex2 = 1 }

    for (i = 0; i < dots.length; i++) {
        dots[i].className = dots[i].className.replace(" active", "")
    }

    slides[slideIndex2 - 1].style.display = "block";
    dots[slideIndex2 - 1].className += " active";
    setTimeout(showSlidesAutomatic, 10000);
}