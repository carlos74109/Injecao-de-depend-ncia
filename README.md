Injeção de dependência e inversão de controle.

Tirei da classe "PagamentoTaxa", a responsabilidade de instanciar suas dependencias, passando assim a responsabilidade para a minha classe principal "Program".

Uma injeção de dependecia pode ser implementada de varias formas, Objeto de instanciação(Builder / factory), Container, Construtor.
No caso desse sistema eu usei o Construtor.