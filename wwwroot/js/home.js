document.addEventListener('DOMContentLoaded', function () {
    const paragrafo1 = document.getElementById('linha1');
    const paragrafo2 = document.getElementById('linha2');

    // Armazena o texto completo e limpa os elementos
    const texto1Completo = paragrafo1.textContent;
    paragrafo1.textContent = '';
    const texto2Completo = paragrafo2.textContent;
    paragrafo2.textContent = '';

    // Função de digitação genérica e reutilizável
    function iniciarAnimacaoDigitacao(elemento, texto, callback) {
        let indice = 0;
        const intervalo = 20;

        const cursor = document.createElement('span');
        cursor.classList.add('typing-cursor');
        elemento.parentNode.appendChild(cursor);

        function digitar() {
            if (indice < texto.length) {
                elemento.textContent += texto.charAt(indice);
                indice++;
                setTimeout(digitar, intervalo);
            } else {
                cursor.remove(); // Remove o cursor ao terminar
                if (callback) {
                    callback(); // Chama o próximo passo
                }
            }
        }
        digitar();
    }

    // Inicia a animação sequencialmente
    iniciarAnimacaoDigitacao(paragrafo1, texto1Completo, () => {
        iniciarAnimacaoDigitacao(paragrafo2, texto2Completo);
    });
});