# Factory Method - Notification System

### <img width="28" height="28" src="https://img.icons8.com/color/48/brazil-circular.png" alt="brazil-circular"/>
Essa é uma aplicação de exemplo, mas, com aplicabilidade em aplicações reais que, demostra a utilização do Design Pattern - Factory Method.

### Problema
Você precisa criar uma aplicação que vai emitir notificações para o usuário. Inicialmente a aplicação emitia notificações por e-mail via SendGrid. Mas, para melhorar a versatilidade da aplicação, você identifica que precisa emitir notificações via SMS utilizando o Twilio e o via Push com Firebase. Mas, você não sabe como adicionar essas novas modalidades de notificações de forma eficiente.

### Solução
Você pode usar o padrão Factory Method para criar uma classe factory que cria objetos de notificação com base no tipo de notificação. Dessa forma, você pode adicionar novos tipos de notificação criando uma nova classe de notificação e atualizando a classe factory para criar o novo objeto de notificação.

### Começando

1. Baixe o diretório `factory-method` para o seu computador;
2. Abra um terminal e vá até o diretório onde você baixou;
3. Vá até o diretório `DesignPatterns.FactoryMethod.NotificationSystem.Api` e execute no terminal

```csharp
dotnet run
```

4. Abra o seu navegador e vá para `http://localhost:5000/swagger` para ver a aplicação rodando. Você também pode usar o Postman, Isominia, Apidog ou qualquer outra ferramenta para testar a API.

**OBS:** A aplicação está configurada para executar na porta 5000, caso você deseje alterar a porta, vá até o arquivo `Program.cs` e altere a linha `app.Run()`.

---

### <img width="28" height="28" src="https://img.icons8.com/officexs/16/usa.png" alt="usa"/> 

This is an example application, but with applicability in real applications, which demonstrates the use of the Design Pattern - Factory Method.

### Problem
You need to create an application that will send notifications to the user. Initially, the application sent notifications via email via SendGrid. However, to improve the versatility of the application, you identify that you need to send notifications via SMS using Twilio and via Push with Firebase. However, you don't know how to add these new types of notifications efficiently.


### Solution

You can use the Factory Method pattern to create a factory class that creates notification objects based on the type of notification. This way, you can add new notification types by creating a new notification class and updating the factory class to create the new notification object.


### Getting Started

1. Download the directory `factory-method` to your computer;
2. Open a terminal and go to the directory where you downloaded it;
3. Go to the `DesignPatterns.FactoryMethod.NotificationSystem.Api` directory and run it in the terminal

```csharp
dotnet run
```

4. Open your browser and go to `http://localhost:5000/swagger` to see the application running. You can also use Postman, Isominia, Apidog or any other tool to test the API.

**NOTE:** The application is configured to run on port 5000, if you want to change the port, go to the `Program.cs` file and change the `app.Run()` line.
