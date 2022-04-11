window.MostraAlerta = (message) => {
    alert(message);
}

function getTotalTarefas() {
    DotNet.invokeMethodAsync("Blazor_Tarefas", "ObterTotalTarefas")
        .then(resultado => {
            alert("Total de Tarefas: " + resultado);
        });
}

function getTotalTarefasInstancia(dotnet) {
    return dotnet.invokeMethodAsync("ObterTotalTarefasInstancia")
        .then(resultado => {
            alert("Total de Tarefas: " + resultado);
        });
}