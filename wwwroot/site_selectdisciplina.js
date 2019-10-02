let dropdowndisciplina = $('#IdDisciplina');

dropdowndisciplina.empty();

dropdowndisciplina.append('<option selected="true" disabled>Escolha a disciplina</option>');
dropdowndisciplina.prop('selectedIndex', 0);

const urldisciplina = 'https://localhost:5001/api/disciplina';

// Preencher disciplina
$.getJSON(urldisciplina, function (datadisciplina) {
  $.each(datadisciplina, function (keydisciplina, entrydisciplina) {
    dropdowndisciplina.append($('<option></option>').attr('value', entrydisciplina.id).text(entrydisciplina.nome));
  })
});