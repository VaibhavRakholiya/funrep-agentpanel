const roulette = require("./roulette");
const funTarget = require("./funtarget");
const settings = require("../model/settings/index")

async function AddBet(gameType,betData)
{
    if(gameType == "Roulette")
    {
        roulette.AddBet(betData);
    }
    else if(gameType == "FunTarget")
    {
        funTarget.AddBet(betData);
    }
}
var winningData;

async function CalculateWinnings()
{
    console.log("Calculating winnings.");
    let winningValue = await settings.getAllSetting();
    let commissionValue = await settings.getAllSetting();
    // let commissionValue = await settings.getAllSetting();
    console.log("Commision Value is ",winningValue);

    commissionValue = commissionValue?.[0]?.value;
    winningValue = winningValue?.[1]?.value;

    let funTargetWinningData = await funTarget.CalculateWinnings(winningValue,commissionValue);
    let rouletteWinningData = await roulette.CalculateWinnings(winningValue,commissionValue);

    winningData = 
    {
        funTargetWinningData,
        rouletteWinningData
    }
}

async function SendWinnings(socket)
{
    socket.emit("RES_BET",winningData);
}


module.exports = {AddBet,CalculateWinnings,SendWinnings};