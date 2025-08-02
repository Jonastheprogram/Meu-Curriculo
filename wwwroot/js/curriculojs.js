//script para fazer os cards de cada informação aparecer conforme vai descendo a página
document.addEventListener('DOMContentLoaded', function () {
    const scrollCards = document.querySelectorAll('.scroll-card');

    const observerOptions = {
        root: null, 
        rootMargin: '0px',
        threshold: 0.2 
    };

    const observer = new IntersectionObserver((entries, observer) => {
        entries.forEach(entry => {
            if (entry.isIntersecting) {
                entry.target.classList.add('visible');
                observer.unobserve(entry.target); 
            }
        });
    }, observerOptions);

    scrollCards.forEach(card => {
        observer.observe(card);
    });
});



//script para efeito de texto digitado
document.addEventListener('DOMContentLoaded', function () {
    const sobremimDiv = document.querySelector('.scroll-card');
    const sobremimTextoElement = document.getElementById('sobremim');
    const textoCompleto = sobremimTextoElement.textContent;
    sobremimTextoElement.textContent = '';

    const observerSobreMim = new IntersectionObserver((entries, observer) => {
        entries.forEach(entry => {
            if (entry.isIntersecting) {
                iniciarAnimacaoDigitacao(sobremimTextoElement, textoCompleto);
                observer.unobserve(entry.target); 
            }

        });
    }, { threshold: 0.5 });

    observerSobreMim.observe(sobremimDiv);

    function iniciarAnimacaoDigitacao(elemento, texto) {
        let indice = 0;
        const intervalo = 10;

        function digitar() {
            if (indice < texto.length) {
                elemento.textContent += texto.charAt(indice);
                indice++;
                setTimeout(digitar, intervalo);
            } else {
                cursor.remove();
            }
        }
        digitar();
    }
});



//script para fazer a cópia do número de telefone
function copiarNumero(elemento) {
    const numero = elemento.getAttribute('data-numero');

    navigator.clipboard.writeText(numero).then(() => {
        
        showToast(`Número de telefone copiado com sucesso!`);
    }).catch(err => {
        console.error('Falha ao copiar o número: ', err);
       
        showToast('Não foi possível copiar o número.', 'error');
    });
}


//script para subir a notificação de "copiado com sucesso"
function showToast(message, type = 'success') {
    const container = document.getElementById('toast-container');

    
    const toast = document.createElement('div');
    toast.className = 'toast-message';
    toast.textContent = message;


    if (type === 'error') {
        toast.style.backgroundColor = '#dc3545';
    }

   
    container.appendChild(toast);
    setTimeout(() => {
        toast.classList.add('show');
    }, 10); 

   
    setTimeout(() => {
        toast.classList.remove('show');
      
        toast.addEventListener('transitionend', () => {
            toast.remove();
        });
    }, 3000); 
}