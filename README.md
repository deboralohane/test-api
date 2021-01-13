# test-api
Essa POC tem como finalidade mostrar a estrutura de um teste automatizado de API, utilizando o Refit, Fluent Assertions e XUnit.

Para a execução dos testes é necessário gerar um token no site que utilizamos como exemplo, segue o passo a passo:


1 - Realizar o cadastro no site: https://www.themoviedb.org/
2 - Ir em Configurações > API > Solicitar API key
3 - No projeto, ir no arquivo ApiTestExample\Infrastructure\Fixture\BaseFixture.cs e inserir o TOKEN gerado acima.
