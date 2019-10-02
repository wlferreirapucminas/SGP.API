const uri = $("#api").val();

function addAvaliacao() {

  const item = {

    iddisciplina: $("#IdDisciplina").val(),
    idmateria: $("#IdMateria").val(),
    descricao: $("#Descricao").val()

  };



  $.ajax({

    type: "POST",

    accepts: "application/json",

    url: uri,

    contentType: "application/json",

    data: JSON.stringify(item),

    error: function(jqXHR, textStatus, errorThrown) {

      alert("Erro de registro de avaliação.");

    },

    success: function(result) {

        alert("Avaliação registrada com sucesso.");

      $("#IdMateria").val("");
      $("#IdDisciplina").val("");
      $("#Descricao").val("");

    }

  });

}