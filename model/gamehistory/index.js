const mongoose = require("mongoose");
const moment = require("moment");

const gameHistorySchema = new mongoose.Schema({
  game_type: {
    type: String,
  },
  not_open_number: {
    type: String,
  },
  created_at: {
    type: String,
  },
  // expireAt: { type: Date, default: Date.now() + (60000 * 60 * 24 * 2), expires: 6000 }
  },{timestamps : true});
//  gameHistorySchema.index({ expireAt: 1 }, { expireAfterSeconds: 0 });

module.exports = mongoose.model("gamehistory", gameHistorySchema);