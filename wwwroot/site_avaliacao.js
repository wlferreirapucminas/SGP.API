let dropdownavaliacao = $('#avaliacao');

dropdownavaliacao.empty();

dropdownavaliacao.append('<option selected="true" disabled>Escolha a avaliacao</option>');
dropdownavaliacao.prop('selectedIndex', 0);

const urlavaliacao = 'https://localhost:5001/api/avaliacao';

// Preencher avaliacao
$.getJSON(urlavaliacao, function (dataavaliacao) {
  $.each(dataavaliacao, function (keyavaliacao, entryavaliacao) {
    dropdownavaliacao.append($('<option></option>').attr('value', entryavaliacao.id).text(entryavaliacao.nome));
  })
});