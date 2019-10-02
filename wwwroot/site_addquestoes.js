const uri = $("#api").val();

function addQuestao() {

  const item = {

    idavaliacao: $("#IdAvaliacao").val(),
    tipo: $("#Tipo").val(),
    enunciado: $("#Enunciado").val()

  };



  $.ajax({

    type: "POST",

    accepts: "application/json",

    url: uri,

    contentType: "application/json",

    data: JSON.stringify(item),

    error: function(jqXHR, textStatus, errorThrown) {

      alert("Erro de registro de questão.");
      //alert(JSON.stringify(item));

    },

    success: function(result) {

        alert("Questão registrada com sucesso.");

      $("#IdAvaliacao").val("");
      $("#Tipo").val("");
      $("#Enunciado").val("");

    }

  });

}