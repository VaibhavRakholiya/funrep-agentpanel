const gameHistory = require('../model/gamehistory/gamehistory');
const utilMethods = require('./utilmethods');

var allBets = [];

async function AddBet(data)
{
  let socketId = data.socketId;
  let betAmount = data.betAmount;
  let betNumbers = data.betNumbers;

  result = 
  {
    socketId,
    betAmount,
    betNumbers
  }

  allBets.push(result);
}

async function CalculateWinnings(winningValue,commissionValue)
{
  let spinStopNumber = await findLeastBettedNumber(winningValue); // Generating Random Number on which ball will be stopped.
  let result =
  {
    gameType : "Roulette",
    winningPlayers : [],
    spinStopNumber
  };

  console.log('spinStopNumber Roulette: ', spinStopNumber);
  gameHistory.CreateGameHistory("Roulette",spinStopNumber); // Creating game history to show on admin panel.

  for (let index = 0; index < allBets.length; index++) 
  {
    const element = allBets[index];
    let betAmount = element.betAmount;
    let splittedNumbers = element.betNumbers.split(",");

    let totalNumber = splittedNumbers.length;
    let winningMultiplier = await GetWinningMultiplier(totalNumber);
    let isUserWinning = splittedNumbers.includes(spinStopNumber.toString()); // Checking whether user is winning or not.

    if(isUserWinning)
    {
      finalWinnings = winningMultiplier * betAmount; // Final Winnings for User.
      result.winningPlayers.push(
        {
          socketId : element.socketId,
          winningAmount : parseFloat(finalWinnings) * parseFloat(commissionValue) * 0.01
        }
      )
    }
  }
  allBets = [];

  console.log("Winning Players are ",result);
  return result;
}

async function GetWinningMultiplier(totalNumber)
{
  let winningMultiplier = 0;

  if (totalNumber == 1) {
    winningMultiplier = 35;
  } else if (totalNumber == 2) {
    winningMultiplier = 17;
  } else if (totalNumber == 3) {
    winningMultiplier = 11;
  } else if (totalNumber == 4) {
    winningMultiplier = 8;
  } else if (totalNumber == 12) {
    winningMultiplier = 2;
  } else if (totalNumber == 17) {
    winningMultiplier = 1;
  } else {
    console.log("Invalid Request bet amount.");
  }

  return winningMultiplier;
}

async function findLeastBettedNumber(winningValue)
{
  let betOnFinalNumber = 0;

  let betOnNumbers = [0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0];

  // console.log("All Bets ",allBets);

  for (let index = 0; index < allBets.length; index++) 
  {
    const bet = allBets[index];
    let betNumbers = bet.betNumbers.split(",");
    for (let index = 0; index < betNumbers.length; index++) {
      const betNumber = parseInt(betNumbers[index]);
      betOnNumbers[betNumber] += parseInt(bet.betAmount);
    }
  }
  let minimumBettedNumber =  betOnNumbers[0];

  if(parseInt(winningValue) == 50)
  {
    minimumBettedNumber = utilMethods.findNearestMean(betOnNumbers);
  }
  else
  {
    minimumBettedNumber =  parseInt(winningValue) < 50 ? Math.min(...betOnNumbers) : Math.max(...betOnNumbers);
  }

  let leastBettedIndexes = await utilMethods.getAllIndexes(betOnNumbers,minimumBettedNumber);
  let randomNumber = Math.floor((Math.random() * leastBettedIndexes.length));
  betOnFinalNumber = leastBettedIndexes[randomNumber];
  if(betOnFinalNumber == null || betOnFinalNumber == undefined)
  {
    betOnFinalNumber = Math.floor(Math.random() * (betOnNumbers.length-1));
  }

  return betOnFinalNumber-1;
}

module.exports = { AddBet ,CalculateWinnings};
