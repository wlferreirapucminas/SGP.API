let dropdownmateria = $('#IdMateria');

dropdownmateria.empty();

dropdownmateria.append('<option selected="true" disabled>Escolha a materia</option>');
dropdownmateria.prop('selectedIndex', 0);

const urlmateria = 'https://localhost:5001/api/materia';

// Preencher materia
$.getJSON(urlmateria, function (datamateria) {
  $.each(datamateria, function (keymateria, entrymateria) {
    dropdownmateria.append($('<option></option>').attr('value', entrymateria.id).text(entrymateria.nome));
  })
});