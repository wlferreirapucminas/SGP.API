let dropdownquestoes = $('#questoes');

dropdownquestoes.empty();

dropdownquestoes.append('<option selected="true" disabled>Escolha a questao</option>');
dropdownquestoes.prop('selectedIndex', 0);

const urlquestoes = 'https://localhost:5001/api/questoes';

// Preencher materia
$.getJSON(urlquestoes, function (dataquestoes) {
  $.each(dataquestoes, function (keyquestoes, entryquestoes) {
    dropdownquestoes.append($('<option></option>').attr('value', entryquestoes.id).text(entryquestoes.nome));
  })
});