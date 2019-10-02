$(window).load(function () {
    $('#SalvarItinerario').click(function () {
        var doc = new jsPDF();

        var positionY = 32;

        doc.setFont("helvetica");
        doc.setFontType("bold");
        doc.setTextColor(0, 0, 0);
        doc.setFontSize(12);
        doc.text(10, 10, $('#modalItinerario .modal-title').text());

        console.log($('#modalItinerario .modal-title').text());


        doc.line(0, 15, 220, 15);
        doc.line(0, 22, 220, 22);
        
        //-------------IDA-------------//
        
        doc.setFont("times");
        doc.setFontType("bold");
        doc.setTextColor(0, 0, 0);
        doc.setFontSize(14);
        doc.text(10, 20, 'IDA');

        $('.ida .rua').each(function (index, element) {
            doc.setFont("helvetica");
            doc.setFontType("normal");
            doc.setTextColor(0, 0, 0);
            doc.setFontSize(10);
            doc.text(10, positionY, element.innerHTML);
            positionY += 5;
            console.log(element.innerHTML);
        });

        //-------------VOLTA-------------//

        positionY = 32;

        doc.setFont("times");
        doc.setFontType("bold");
        doc.setTextColor(0, 0, 0);
        doc.setFontSize(14);
        doc.text(110, 20, 'VOLTA');

        $('.volta .rua').each(function (index, element) {
            doc.setFont("helvetica");
            doc.setFontType("normal");
            doc.setTextColor(0, 0, 0);
            doc.setFontSize(10);
            doc.text(110, positionY, element.innerHTML);
            positionY += 5;
            console.log(element.innerHTML);
        });




        //RODAPÉ 
        var d = new Date();
        doc.setFont("helvetica");
        doc.setFontType("bold");
        doc.setTextColor(150);
        doc.setFontSize(10);
        doc.text(150, positionY+5, "Salvo em " + d.toLocaleString());

        doc.save('Itinerario' + $('#buscaItinerario').val().slice(0, 3));

        //VERIFICA SE CHEGOU AO FINAL DA PÁGINA
        function CriaPagina(height) {
            if (height > 280) {
                doc.addPage();
                height = 10;
            }
            return height;
        }
    });
    


    
});