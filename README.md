# Dotnet-RPG
API construída baseada nos principais recursos de um Jogo de RPG, podendo criar usuários, personagens e outras funcionalidades. A API construída baseia-se em um jogo de RPG, onde é possível fazer autenticação com registros e login de novos usuários através do sistema de Tokens (JWT). Cada usuário pode criar infinitos personagens dentre as classes estabelecidas: Cavaleiro, Mago ou Clérico, podendo também adicionar armas e skills para esses personagens.

## Demonstração em Vídeo (clique no botão abaixo para visualizar)
[<img src="https://img.shields.io/badge/YouTube-FF0000?style=for-the-badge&logo=youtube&logoColor=white">](https://www.youtube.com/watch?v=Mqdelbg_7sE&t=10s)

## Tela Inicial
![image](https://user-images.githubusercontent.com/10932478/185773136-512f3ae9-9cf8-4cf8-8d76-ebb63ae866f6.png)
Essa é a tela inicial da API. Para começar, cria-se um novo usuário para poder ter acesso a todas as funcionalidades que a API oferece.

## Registro
![image](https://user-images.githubusercontent.com/10932478/185773140-efd41b75-3734-4687-8238-6d3819941639.png)
Na Seção "Auth" e clicando no método POST em registrar podemos criar um novo usuário.

## Login
![image](https://user-images.githubusercontent.com/10932478/185773145-a367b18a-6d03-4c13-817a-b7e20842ea26.png)
Com o novo usuário cadastrado, podemos então fazer o login com as mesmas informações registradas anteriormente.

## Gerando o Token
![image](https://user-images.githubusercontent.com/10932478/185773147-11514584-49b2-4712-8340-fa24b7aa8848.png)
No método POST de login, após preencher as informações do usuário e clicar em "Execute", um Token é gerado. Esse Token é responsável por fazer a autenticação na API.

## Autenticação
![image](https://user-images.githubusercontent.com/10932478/185773151-d599077b-dc09-4bc9-b210-4b3c1a8ef8b7.png)
Clicando em "Authorize" no canto direito superior direito e inserindo o Token gerado, o usuário é então autenticado no sistema da API podendo ter acesso a outras funcionalidades.
 
## Cadastro de Personagens
![image](https://user-images.githubusercontent.com/10932478/185773164-37b9ca61-a1b4-488d-982f-cf8e94d69d8d.png)
Clicando no método POST  em Character, podemos criar um novo personagem e escolher uma classe na qual esse personagem pertence.

## Personagens Cadastrados
![image](https://user-images.githubusercontent.com/10932478/185773178-83a3d1e3-733d-42fd-b597-f27cd8fd96fa.png)
Podemos perceber que o personagem foi cadastrado com sucesso ao banco de dados da API. No entanto, os campos "Weapon" e "Skills" permanecem vazios. Vamos então adicionar as armas e as skills do persongem.

## Cadastro de Armas
![image](https://user-images.githubusercontent.com/10932478/185773181-5f5389c8-f6f0-4066-a516-d6d1c6c6ec87.png)
Clicando no método POST de Weapon, podemos então adicionar uma arma ao personagem que acabamos de criar.

## Resultado do Personagem com Arma
![image](https://user-images.githubusercontent.com/10932478/185773189-227e3d85-f8a5-4432-b6c0-fc7faa5aa196.png)
Podemos perceber então que a arma foi adicionado. Falta então as Skills.

## Cadastro de Skills
![image](https://user-images.githubusercontent.com/10932478/185773197-f1048c7d-8d22-4d88-92e1-4bb43f7d6434.png)
As Skills são adicionadas de acordo com o ID específico de cada Skill predefinida no banco de dados. E elas podem ser associadas aos personagens de acordo com o ID específico do personagem.

## Resultado do Personagem com Skills
![image](https://user-images.githubusercontent.com/10932478/185773204-4d9d3208-077e-4fd6-98a5-073d15082e08.png)
Podemos perceber então que a Skill "Sabedoria" foi adicionada. Mas pode-se também adicionar diversas skills diferentes a um mesmo personagem.

## Adicionando mais Skills
![image](https://user-images.githubusercontent.com/10932478/185773209-45622eef-165e-46bd-a4e6-91dd6b6b9d86.png)
E assim fica o personagem preenchido com todas as informações.

## Atualizando os Personagens (UPDATE)
![image](https://user-images.githubusercontent.com/10932478/185773217-85177a2d-7935-4c4b-9246-fd90668e2062.png)
Podemos então modificar ou adicionar mais informações ao personagem com o método "Update". No caso em exemplo, atualizamos o nome do personagem.

## Excluindo Personagens (DELETE)
![image](https://user-images.githubusercontent.com/10932478/185773226-42a21f0f-de01-4266-8ae5-0c48b1e8558b.png)
Podemos também excluir o personagem fornecendo seu ID.

## Observações
1 - Este repositório está organizado em diversas branchs afim de separar cada nova funcionalidade que foi implementada
</br>2 - Caso queira executar a API, acesse a apartir da branch "35_AddSkillsCharacter" ou <a href="https://github.com/antonioscript/Dotnet-RPG/tree/35_AddSkillsCharacter">Clique Aqui</a>, pois todas as branchs depois dessa são apenas de teste;
</br> 3 - Foi utilizado nesse projeto o SQL Server, mas você pode utilizar qualquer outro, apenas mudando o "Connection String";




