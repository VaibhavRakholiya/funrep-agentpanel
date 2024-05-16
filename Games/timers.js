const betController = require("./betcontroller");

var timerTime = process.env.ROUND_TIMER;
var tempTimer = timerTime;
var allSockets = [];

async function StartTimer(delay)
{
    // console.log('tempTimer: ', tempTimer);
        setTimeout(async () => 
        {
            if(tempTimer == 5)
            {
                await betController.CalculateWinnings(); // Calculating winnings one second before sending events.
            }

            if(tempTimer == 0)
            {
                tempTimer = timerTime;
            }

            if(tempTimer == 0)
            {
                delay = 1000;
            }
            else
            {
                delay = 1000;
            }
            await StartTimer(delay);

            tempTimer--;
        }, delay);
}

async function SendTimerEventEverySecond(socket,delay)
{
    if(allSockets.includes(socket.id) == false)
    {
        return;
    }

    setTimeout(async () => 
    {
        await socket.emit("RES_TIMER",{timer : parseInt(tempTimer)});
        if(tempTimer == 1)
        {
            await betController.SendWinnings(socket);
        }

        if(tempTimer == 0)
        {
            delay = 1000;
        }
        else
        {
            delay = 1000;
        }

        await SendTimerEventEverySecond(socket,delay);
    }, delay,socket);
}

function RegisterSocket(socketId)
{
    allSockets.push(socketId);
}

function StopTimer(socketId)
{
    allSockets.splice(allSockets.indexOf(socketId), 1);
}

module.exports = 
{
    StartTimer,SendTimerEventEverySecond,StopTimer,RegisterSocket
}