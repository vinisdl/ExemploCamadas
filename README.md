# ExemploCamadas

Este é um projeto de exemplo que demonstra a implementação de uma arquitetura em camadas, separando responsabilidades entre apresentação, lógica de negócio e acesso a dados. Este projeto serve como uma base para o desenvolvimento de aplicações escaláveis e de fácil manutenção.

## Pré-requisitos

- Python 3.x
- Virtualenv ou Poetry para gerenciamento de dependências (opcional)

## Instalação

1. Clone o repositório:
   git clone https://github.com/vinisdl/ExemploCamadas.git

2. Acesse o diretório do projeto:
   cd ExemploCamadas

3. Instale as dependências (se necessário):
   pip install -r requirements.txt

## Execução

A aplicação pode ser iniciada em uma das seguintes portas, com configurações de CORS e iframes habilitadas:

- Para iniciar o servidor na porta 52880:

  python app.py --host=0.0.0.0 --port=52880

- Para iniciar o servidor na porta 58489:

  python app.py --host=0.0.0.0 --port=58489

Verifique o comando de execução conforme a implementação do servidor web presente no repositório.

## Configurações

O projeto já está configurado para permitir requisições CORS e acesso via iframes, permitindo a integração com outras aplicações.

## Contribuição

Sinta-se à vontade para enviar pull requests e relatar issues.

## Licença

Este projeto está licenciado sob os termos da licença MIT.
