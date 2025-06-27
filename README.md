# WuwaTools
A bunch of useful WuWa tools\
Releasing this as Im no longer interested in WuWa RE'ing\
Some of the code is 1.5+ years old, so don't expect it to be well-written

# protodumperv2.ts
- Extremely slow and unoptimized, but works just fine with full dump (in Protocol.js, replace `$protobuf=require("protobuf")` with `$protobuf=require("./protobuf.js")`)
# fbsdumper.ts
- Somewhat quick and efficient, outputs FlatBuffers schema for the parser (in GameUtils.js, delete everything after `exports.GameUtils=void 0;`)
# WWParser
- Parses BinData and TextMaps from game's ConfigDB's

## For protodumperv2 and fbsdumper you need to place decompiled `JavaScript` folder next to the scripts and run them using ts-node

# I DO NOT CLAIM ANY RESPONSIBILITY FOR ANY USAGE OF THIS SOFTWARE, THE SOFTWARE IS MADE 100% FOR EDUCATIONAL PURPOSES ONLY

Copyright© Hiro420