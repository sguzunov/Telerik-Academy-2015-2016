(function () {
    var ctx = document.getElementById('the-canvas').getContext('2d');


    function drawHouse() {
        ctx.strokeStyle = 'black';
        ctx.fillStyle = '#965A5A';
        ctx.lineWidth = 1.3;

        function drawWindow(xPosition, yPosition) {
            var partWidth = 35,
                patHeight = 20,
                spacing = 2;
            ctx.fillStyle = 'black';

            ctx.rect(xPosition, yPosition, partWidth, patHeight);
            ctx.rect(xPosition + partWidth + spacing, yPosition, partWidth, patHeight);
            ctx.rect(xPosition, yPosition + patHeight + spacing, partWidth, patHeight);
            ctx.rect(xPosition + partWidth + spacing, yPosition + patHeight + spacing, partWidth, patHeight);
            ctx.fill();
        }

        // Drawing main forms
        ctx.beginPath();
        ctx.moveTo(700, 150);
        ctx.lineTo(900, 150);
        ctx.lineTo(800, 50);
        ctx.closePath();
        ctx.rect(700, 150, 200, 150);
        ctx.fill();
        ctx.stroke();

        // Drawing chimney
        ctx.beginPath();
        ctx.moveTo(850, 140);
        ctx.lineTo(850, 80);
        ctx.lineTo(870, 80);
        ctx.lineTo(870, 140);
        ctx.fill();
        ctx.stroke();

        ctx.beginPath();
        ctx.save();
        ctx.scale(2, 1);
        ctx.arc(860 / 2, 80, 5, Math.PI, 3 * Math.PI);
        ctx.restore();
        ctx.closePath();
        ctx.fill();
        ctx.stroke();

        // Drawing windows
        ctx.beginPath();
        drawWindow(715, 165);
        drawWindow(812, 165);
        drawWindow(812, 230);
        ctx.closePath();

        // Drawing door
        ctx.beginPath();
        ctx.moveTo(720, 220);
        ctx.lineTo()
    }

    function drawCycle() {
        ctx.fillStyle = '#90CAD7';
        ctx.strokeStyle = '#337D8F';

        // Drawing bicycles
        ctx.beginPath();
        ctx.arc(150, 150, 50, 0, 2 * Math.PI);
        ctx.closePath();
        ctx.fill();
        ctx.stroke();

        ctx.beginPath();
        ctx.arc(350, 150, 50, 0, 2 * Math.PI);
        ctx.closePath();
        ctx.fill();
        ctx.stroke();

        // Draw the main body
        ctx.beginPath();
        ctx.moveTo(150, 150);
        ctx.lineTo(220, 80);
        ctx.lineTo(340, 80);
        ctx.lineTo(240, 150);
        ctx.closePath();
        ctx.stroke();

        // Draw pedals
        ctx.beginPath();
        ctx.arc(240, 150, 10, 0, 2 * Math.PI);
        ctx.moveTo(232, 142);
        ctx.lineTo(227, 135);
        ctx.moveTo(247, 157);
        ctx.lineTo(252, 164);
        ctx.closePath();
        ctx.stroke();

        // Draw the left parts
        ctx.beginPath();
        ctx.moveTo(240, 150);
        ctx.lineTo(210, 60);

        ctx.moveTo(200, 60);
        ctx.lineTo(220, 60);

        ctx.moveTo(350, 150);
        ctx.lineTo(335, 50);
        ctx.lineTo(355, 35);
        ctx.moveTo(335, 50);
        ctx.lineTo(310, 55);
        ctx.closePath();
        ctx.stroke();
    }

    function drawHead() {
        ctx.fillStyle = '#90CAD7';
        ctx.strokeStyle = '#22545F';
        ctx.lineWidth = 2;

        function drawEye(xPosition, yPosition) {
            var radius = 9;

            ctx.save();
            ctx.beginPath();
            ctx.scale(1.5, 1);
            ctx.arc(xPosition / 1.5, yPosition, radius, 0, 2 * Math.PI);
            ctx.closePath();
            ctx.restore();
            ctx.stroke();

            ctx.beginPath();
            ctx.save();
            ctx.fillStyle = '#22545F';
            ctx.scale(1, 2);
            ctx.arc(xPosition - 5, yPosition / 2, 3, 0, 2 * Math.PI);
            ctx.closePath();
            ctx.fill();
            ctx.restore();
        }

        // Drawing face
        ctx.beginPath();
        ctx.arc(150, 500, 70, 0, 2 * Math.PI);
        ctx.closePath();
        ctx.fill();
        ctx.stroke();

        // Drawing the nose
        ctx.moveTo(140, 500);
        ctx.lineTo(120, 500);
        ctx.lineTo(140, 470);
        ctx.stroke();

        // Drawing hat
        ctx.beginPath();
        ctx.fillStyle = '#396693';
        ctx.strokeStyle = '#262626';
        ctx.lineWidth = 2;

        // Bottom arc
        ctx.save();
        ctx.scale(3, 0.7);
        ctx.arc(145 / 3, 620, 25, 0, 2 * Math.PI);
        ctx.fill();
        ctx.restore();
        ctx.stroke();

        ctx.beginPath();
        ctx.moveTo(190, 340);
        ctx.lineTo(190, 430);
        ctx.stroke();
        ctx.save();
        ctx.scale(3, 0.7);
        ctx.arc(150 / 3, 610, 13.5, 0, Math.PI);
        ctx.restore();
        ctx.lineTo(109, 340);
        ctx.stroke();
        ctx.save();
        ctx.scale(3, 0.7);
        ctx.arc(150 / 3, 482, 13.5, Math.PI, 3 * Math.PI);
        ctx.restore();
        ctx.fill();
        ctx.stroke();
        ctx.closePath();

        // Draw eyes
        ctx.beginPath();
        ctx.fillStyle = '#90CAD7';
        ctx.strokeStyle = '#22545F';
        ctx.lineWidth = 2;

        drawEye(110, 470);
        drawEye(170, 470);

        // Draw mouth
        ctx.beginPath();
        ctx.save();
        ctx.rotate(10 * Math.PI / 180);
        ctx.scale(4, 1);
        ctx.arc(280 / 5, 505, 7, 0, 2 * Math.PI);
        ctx.restore();
        ctx.stroke();
        ctx.closePath();

    }

    drawHouse();
    drawCycle();
    drawHead();
}());

