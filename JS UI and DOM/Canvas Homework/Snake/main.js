(function () {
    'use strict';
    var canvas = document.getElementById('the-canvas'),
        ctx = canvas.getContext('2d'),
        snake,
        food,
        CONSTANTS = {
            SNAKE_INITIAL_LENGTH: 4,
            SNAKE_STEP: 0.5
        },
        pixelSize = 7,
        directions = {
            up: 'up',
            down: 'down',
            right: 'right',
            left: 'left'
        };

    function drawRectangle(xPosition, yPosition) {
        ctx.fillStyle = 'green';
        ctx.strokeStyle = 'blue';
        ctx.lineWidth = 0.5;

        ctx.beginPath();
        ctx.rect(xPosition * pixelSize, yPosition, pixelSize, pixelSize);
        ctx.fill();
        ctx.stroke();
    }

    snake = (function () {
        var snake;

        function createInitialSnake() {
            var initialSnake = [],
                i;
            for (i = CONSTANTS.SNAKE_INITIAL_LENGTH - 1; i >= 0; i -= 1) {
                initialSnake.push({
                    x: i,
                    y: 0
                });
            }

            return initialSnake;
        }

        snake = {
            init: function () {
                this.snakeArray = createInitialSnake();

                return this;
            },
            grow: function (newTail) {
                this.snakeArray.push(
                    newTail.x,
                    newTail.y
                );

                return this;
            },
            draw: function () {
                var i,
                    len,
                    currentSnakePart;
                for (i = 0, len = this.snakeArray.length; i < len; i += 1) {
                    currentSnakePart = this.snakeArray[i];
                    drawRectangle(currentSnakePart.x, currentSnakePart.y);
                }

                return this;
            },
            move: function (direction) {
                if (direction === undefined) {
                    throw new Error('Undefined cannot be an argument.');
                }
                if (!directions.hasOwnProperty(direction)) {
                    throw new Error('Invalid direction!');
                }

                // set the new movement state
                if (direction === directions.up) {
                    this.snakeArray.forEach(function (part) {
                        part.y -= CONSTANTS.SNAKE_STEP;
                    });
                } else if (direction === directions.down) {
                    this.snakeArray.forEach(function (part) {
                        part.y += CONSTANTS.SNAKE_STEP;
                    });
                } else if (direction === directions.right) {
                    this.snakeArray.forEach(function (part) {
                        part.x += CONSTANTS.SNAKE_STEP;
                    });
                } else if (direction === directions.left) {
                    this.snakeArray.forEach(function (part) {
                        part.x -= CONSTANTS.SNAKE_STEP;
                    });
                }

                return this;
            }
        };

        return snake;
    }());

    food = (function () {
        var food = {
            x: Math.round(Math.random() * (canvas.width - pixelSize) / pixelSize),
            y: Math.round(Math.random() * (canvas.height - pixelSize) / pixelSize),
            draw: function () {
                drawRectangle(this.x, this.y);
            }
        };

        return food;
    }());

    function gameFactory(player) {
        food.draw();
    }

    function init() {
        var player = snake.init();
        ctx.clearRect(0, 0, canvas.width, canvas.height);
        player.draw();
        gameFactory(player)

        requestAnimationFrame(gameFactory);
    }

    init();
}());
