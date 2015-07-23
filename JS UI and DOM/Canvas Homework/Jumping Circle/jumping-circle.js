(function () {
    var canvas = document.getElementById('the-canvas'),
        ctx = canvas.getContext('2d'),
        x = canvas.width / 2,
        y = canvas.height / 2,
        dx = 2,
        dy = 1;
    ctx.fillStyle = 'green';

    function circle(xPosition, yPosition) {
        ctx.beginPath();
        ctx.arc(xPosition, yPosition, 2, 0, 2 * Math.PI);
        ctx.closePath();
        ctx.fill();
    }

    function draw() {
        ctx.clearRect(0, 0, canvas.width, canvas.height);
        circle(x, y);

        if (x + dx >= canvas.width || x + dx < 0) {
            dx = -dx;
        }
        if (y + dy >= canvas.height || y + dy < 0) {
            dy = -dy;
        }

        x += dx;
        y += dy;

        requestAnimationFrame(draw);
    }

    draw();
}());