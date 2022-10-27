﻿using System.Diagnostics;
using Xunit;

namespace Nethereum.EVM.UnitTests
{
    public class ProgramsUtilsTests
    {

        [Fact]
        public void ShouldDisassmebleToString()
        {
            var byteCode = ByteCodeDisassemblyOuput.Bytecode;
            var output = ProgramInstructionsUtils.DisassembleToString(byteCode);
            Assert.Equal(ByteCodeDisassemblyOuput.DisasemblyOutput, output);
        }

      
        [Fact]
        public void ShouldDissambleToStringSimplified()
        {
            var byteCode = ByteCodeDisassemblyOuput.Bytecode;
            var output1_1 = " PUSH1 0x80 PUSH1 0x40 MSTORE CALLVALUE DUP1 ISZERO PUSH2 0x10 JUMPI PUSH1 0x0 DUP1 REVERT JUMPDEST POP PUSH1 0x4 CALLDATASIZE LT PUSH2 0x41 JUMPI PUSH1 0x0 CALLDATALOAD PUSH1 0xE0 SHR DUP1 PUSH4 0x18160DDD EQ PUSH2 0x46 JUMPI DUP1 PUSH4 0x70A08231 EQ PUSH2 0x64 JUMPI DUP1 PUSH4 0xA9059CBB EQ PUSH2 0x94 JUMPI JUMPDEST PUSH1 0x0 DUP1 REVERT JUMPDEST PUSH2 0x4E PUSH2 0xC4 JUMP JUMPDEST PUSH1 0x40 MLOAD PUSH2 0x5B SWAP2 SWAP1 PUSH2 0x393 JUMP JUMPDEST PUSH1 0x40 MLOAD DUP1 SWAP2 SUB SWAP1 RETURN JUMPDEST PUSH2 0x7E PUSH1 0x4 DUP1 CALLDATASIZE SUB DUP2 ADD SWAP1 PUSH2 0x79 SWAP2 SWAP1 PUSH2 0x2ED JUMP JUMPDEST PUSH2 0xCD JUMP JUMPDEST PUSH1 0x40 MLOAD PUSH2 0x8B SWAP2 SWAP1 PUSH2 0x393 JUMP JUMPDEST PUSH1 0x40 MLOAD DUP1 SWAP2 SUB SWAP1 RETURN JUMPDEST PUSH2 0xAE PUSH1 0x4 DUP1 CALLDATASIZE SUB DUP2 ADD SWAP1 PUSH2 0xA9 SWAP2 SWAP1 PUSH2 0x31A JUMP JUMPDEST PUSH2 0x116 JUMP JUMPDEST PUSH1 0x40 MLOAD PUSH2 0xBB SWAP2 SWAP1 PUSH2 0x378 JUMP JUMPDEST PUSH1 0x40 MLOAD DUP1 SWAP2 SUB SWAP1 RETURN JUMPDEST PUSH1 0x0 DUP1 SLOAD SWAP1 POP SWAP1 JUMP JUMPDEST PUSH1 0x0 PUSH1 0x1 PUSH1 0x0 DUP4 PUSH20 0xFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF AND PUSH20 0xFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF AND DUP2 MSTORE PUSH1 0x20 ADD SWAP1 DUP2 MSTORE PUSH1 0x20 ADD PUSH1 0x0 KECCAK256 SLOAD SWAP1 POP SWAP2 SWAP1 POP JUMP JUMPDEST PUSH1 0x0 DUP1 PUSH20 0xFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF AND DUP4 PUSH20 0xFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF AND EQ ISZERO PUSH2 0x151 JUMPI PUSH1 0x0 DUP1 REVERT JUMPDEST PUSH1 0x1 PUSH1 0x0 CALLER PUSH20 0xFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF AND PUSH20 0xFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF AND DUP2 MSTORE PUSH1 0x20 ADD SWAP1 DUP2 MSTORE PUSH1 0x20 ADD PUSH1 0x0 KECCAK256 SLOAD DUP3 GT ISZERO PUSH2 0x19D JUMPI PUSH1 0x0 DUP1 REVERT JUMPDEST DUP2 PUSH1 0x1 PUSH1 0x0 CALLER PUSH20 0xFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF AND PUSH20 0xFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF AND DUP2 MSTORE PUSH1 0x20 ADD SWAP1 DUP2 MSTORE PUSH1 0x20 ADD PUSH1 0x0 KECCAK256 SLOAD PUSH2 0x1E8 SWAP2 SWAP1 PUSH2 0x404 JUMP JUMPDEST PUSH1 0x1 PUSH1 0x0 CALLER PUSH20 0xFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF AND PUSH20 0xFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF AND DUP2 MSTORE PUSH1 0x20 ADD SWAP1 DUP2 MSTORE PUSH1 0x20 ADD PUSH1 0x0 KECCAK256 DUP2 SWAP1 SSTORE POP DUP2 PUSH1 0x1 PUSH1 0x0 DUP6 PUSH20 0xFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF AND PUSH20 0xFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF AND DUP2 MSTORE PUSH1 0x20 ADD SWAP1 DUP2 MSTORE PUSH1 0x20 ADD PUSH1 0x0 KECCAK256 SLOAD PUSH2 0x276 SWAP2 SWAP1 PUSH2 0x3AE JUMP JUMPDEST PUSH1 0x1 PUSH1 0x0 DUP6 PUSH20 0xFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF AND PUSH20 0xFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF AND DUP2 MSTORE PUSH1 0x20 ADD SWAP1 DUP2 MSTORE PUSH1 0x20 ADD PUSH1 0x0 KECCAK256 DUP2 SWAP1 SSTORE POP PUSH1 0x1 SWAP1 POP SWAP3 SWAP2 POP POP JUMP JUMPDEST PUSH1 0x0 DUP2 CALLDATALOAD SWAP1 POP PUSH2 0x2D2 DUP2 PUSH2 0x4B4 JUMP JUMPDEST SWAP3 SWAP2 POP POP JUMP JUMPDEST PUSH1 0x0 DUP2 CALLDATALOAD SWAP1 POP PUSH2 0x2E7 DUP2 PUSH2 0x4CB JUMP JUMPDEST SWAP3 SWAP2 POP POP JUMP JUMPDEST PUSH1 0x0 PUSH1 0x20 DUP3 DUP5 SUB SLT ISZERO PUSH2 0x303 JUMPI PUSH2 0x302 PUSH2 0x4AF JUMP JUMPDEST JUMPDEST PUSH1 0x0 PUSH2 0x311 DUP5 DUP3 DUP6 ADD PUSH2 0x2C3 JUMP JUMPDEST SWAP2 POP POP SWAP3 SWAP2 POP POP JUMP JUMPDEST PUSH1 0x0 DUP1 PUSH1 0x40 DUP4 DUP6 SUB SLT ISZERO PUSH2 0x331 JUMPI PUSH2 0x330 PUSH2 0x4AF JUMP JUMPDEST JUMPDEST PUSH1 0x0 PUSH2 0x33F DUP6 DUP3 DUP7 ADD PUSH2 0x2C3 JUMP JUMPDEST SWAP3 POP POP PUSH1 0x20 PUSH2 0x350 DUP6 DUP3 DUP7 ADD PUSH2 0x2D8 JUMP JUMPDEST SWAP2 POP POP SWAP3 POP SWAP3 SWAP1 POP JUMP JUMPDEST PUSH2 0x363 DUP2 PUSH2 0x44A JUMP JUMPDEST DUP3 MSTORE POP POP JUMP JUMPDEST PUSH2 0x372 DUP2 PUSH2 0x476 JUMP JUMPDEST DUP3 MSTORE POP POP JUMP JUMPDEST PUSH1 0x0 PUSH1 0x20 DUP3 ADD SWAP1 POP PUSH2 0x38D PUSH1 0x0 DUP4 ADD DUP5 PUSH2 0x35A JUMP JUMPDEST SWAP3 SWAP2 POP POP JUMP JUMPDEST PUSH1 0x0 PUSH1 0x20 DUP3 ADD SWAP1 POP PUSH2 0x3A8 PUSH1 0x0 DUP4 ADD DUP5 PUSH2 0x369 JUMP JUMPDEST SWAP3 SWAP2 POP POP JUMP JUMPDEST PUSH1 0x0 PUSH2 0x3B9 DUP3 PUSH2 0x476 JUMP JUMPDEST SWAP2 POP PUSH2 0x3C4 DUP4 PUSH2 0x476 JUMP JUMPDEST SWAP3 POP DUP3 PUSH32 0xFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF SUB DUP3 GT ISZERO PUSH2 0x3F9 JUMPI PUSH2 0x3F8 PUSH2 0x480 JUMP JUMPDEST JUMPDEST DUP3 DUP3 ADD SWAP1 POP SWAP3 SWAP2 POP POP JUMP JUMPDEST PUSH1 0x0 PUSH2 0x40F DUP3 PUSH2 0x476 JUMP JUMPDEST SWAP2 POP PUSH2 0x41A DUP4 PUSH2 0x476 JUMP JUMPDEST SWAP3 POP DUP3 DUP3 LT ISZERO PUSH2 0x42D JUMPI PUSH2 0x42C PUSH2 0x480 JUMP JUMPDEST JUMPDEST DUP3 DUP3 SUB SWAP1 POP SWAP3 SWAP2 POP POP JUMP JUMPDEST PUSH1 0x0 PUSH2 0x443 DUP3 PUSH2 0x456 JUMP JUMPDEST SWAP1 POP SWAP2 SWAP1 POP JUMP JUMPDEST PUSH1 0x0 DUP2 ISZERO ISZERO SWAP1 POP SWAP2 SWAP1 POP JUMP JUMPDEST PUSH1 0x0 PUSH20 0xFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF DUP3 AND SWAP1 POP SWAP2 SWAP1 POP JUMP JUMPDEST PUSH1 0x0 DUP2 SWAP1 POP SWAP2 SWAP1 POP JUMP JUMPDEST PUSH32 0x4E487B7100000000000000000000000000000000000000000000000000000000 PUSH1 0x0 MSTORE PUSH1 0x11 PUSH1 0x4 MSTORE PUSH1 0x24 PUSH1 0x0 REVERT JUMPDEST PUSH1 0x0 DUP1 REVERT JUMPDEST PUSH2 0x4BD DUP2 PUSH2 0x438 JUMP JUMPDEST DUP2 EQ PUSH2 0x4C8 JUMPI PUSH1 0x0 DUP1 REVERT JUMPDEST POP JUMP JUMPDEST PUSH2 0x4D4 DUP2 PUSH2 0x476 JUMP JUMPDEST DUP2 EQ PUSH2 0x4DF JUMPI PUSH1 0x0 DUP1 REVERT JUMPDEST POP JUMP INVALID LOG2 PUSH5 0x6970667358 0x22 SLT KECCAK256 0xD DUP14 0xA6 BALANCE 0xC5 0xCA 0xAC 0x28 0xCF NUMBER DUP2 0xF8 0xBC MSTORE STATICCALL SWAP5 SWAP13 SWAP1 REVERT DUP7 0xD5 0xD7 RETURN 0xAD SWAP16 0xC8 PUSH11 0xDFACED5B5764736F6C6343 STOP ADDMOD SMOD STOP CALLER";
            var simplified = ProgramInstructionsUtils.DisassembleSimplifiedToString(byteCode);
            Assert.Equal(output1_1, simplified);
        }

        [Fact] //
        public void Should()
        {
            var byteCode = "3d602d80600a3d3981f3363d3d373d3d3d363d73d68d97363aedf990c2e9b96b7db51b4dc6f30f6b5af43d82803e903d91602b57fd5bf3";
            var simplified = ProgramInstructionsUtils.DisassembleSimplifiedToString(byteCode);

            var byteCode2 = "363d3d373d3d3d363d73d68d97363aedf990c2e9b96b7db51b4dc6f30f6b5af43d82803e903d91602b57fd5bf3";
            var simplified2 = ProgramInstructionsUtils.DisassembleSimplifiedToString(byteCode2);

            var byteCode3 = "6080604052600436106100595760003560e01c806319ab453c146101565780633ccfd60b146101a75780633ef13367146101b15780635e949fa0146102025780636b9f96ea14610253578063b269681d1461025d57610151565b366101515760008054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff166108fc349081150290604051600060405180830381858888f193505050501580156100c4573d6000803e3d6000fd5b507f69b31548dea9b3b707b4dff357d326e3e9348b24e7a6080a218a6edeeec48f9b3334600036604051808573ffffffffffffffffffffffffffffffffffffffff168152602001848152602001806020018281038252848482818152602001925080828437600081840152601f19601f8201169050808301925050509550505050505060405180910390a1005b600080fd5b34801561016257600080fd5b506101a56004803603602081101561017957600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff16906020019092919050505061029e565b005b6101af610311565b005b3480156101bd57600080fd5b50610200600480360360208110156101d457600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190505050610438565b005b34801561020e57600080fd5b506102516004803603602081101561022557600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff16906020019092919050505061063e565b005b61025b610742565b005b34801561026957600080fd5b506102726107c8565b604051808273ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b600060149054906101000a900460ff1661030e57806000806101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055506001600060146101000a81548160ff0219169083151502179055505b50565b60008054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff16146103d2576040517f08c379a00000000000000000000000000000000000000000000000000000000081526004018080602001828103825260108152602001807f4f6e6c792064657374696e6174696f6e0000000000000000000000000000000081525060200191505060405180910390fd5b60003090503373ffffffffffffffffffffffffffffffffffffffff166108fc8273ffffffffffffffffffffffffffffffffffffffff16319081150290604051600060405180830381858888f19350505050158015610434573d6000803e3d6000fd5b5050565b600081905060008173ffffffffffffffffffffffffffffffffffffffff166370a08231306040518263ffffffff1660e01b8152600401808273ffffffffffffffffffffffffffffffffffffffff16815260200191505060206040518083038186803b1580156104a657600080fd5b505afa1580156104ba573d6000803e3d6000fd5b505050506040513d60208110156104d057600080fd5b8101908080519060200190929190505050905060008114156104f157600080fd5b8173ffffffffffffffffffffffffffffffffffffffff1663a9059cbb60008054906101000a900473ffffffffffffffffffffffffffffffffffffffff16836040518363ffffffff1660e01b8152600401808373ffffffffffffffffffffffffffffffffffffffff16815260200182815260200192505050602060405180830381600087803b15801561058257600080fd5b505af1158015610596573d6000803e3d6000fd5b505050506040513d60208110156105ac57600080fd5b81019080805190602001909291905050506105c657600080fd5b7fb4bdccee2343c0b5e592d459c20eb1fa451c96bf88fb685a11aecda6b4ec76b1308285604051808473ffffffffffffffffffffffffffffffffffffffff1681526020018381526020018273ffffffffffffffffffffffffffffffffffffffff168152602001935050505060405180910390a1505050565b60008054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff16146106ff576040517f08c379a00000000000000000000000000000000000000000000000000000000081526004018080602001828103825260108152602001807f4f6e6c792064657374696e6174696f6e0000000000000000000000000000000081525060200191505060405180910390fd5b806000806101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff16021790555050565b600030905060008054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff166108fc8273ffffffffffffffffffffffffffffffffffffffff16319081150290604051600060405180830381858888f193505050501580156107c4573d6000803e3d6000fd5b5050565b60008054906101000a900473ffffffffffffffffffffffffffffffffffffffff168156fea2646970667358221220cb5789c55684de2d7059524ffe8adc5e3cf2d2553794f6747c593b596355cdb864736f6c63430007060033";
            var simplified3 = ProgramInstructionsUtils.DisassembleSimplifiedToString(byteCode3);
        }

        [Fact]
        public void ShouldFindFunctionHashes()
        {
            /*
     "70a08231": "balanceOf(address)",
    "18160ddd": "totalSupply()",
    "a9059cbb": "transfer(address,uint256)"
             **/

            var byteCode = ByteCodeDisassemblyOuput.Bytecode;
            var programInstructions = ProgramInstructionsUtils.GetProgramInstructions(byteCode);
            Assert.True(ProgramInstructionsUtils.ContainsFunctionSignatures(programInstructions, new string[] { "70a08231", "18160ddD", "0xA9059cbb" }));
            Assert.False(ProgramInstructionsUtils.ContainsFunctionSignatures(programInstructions, new string[] { "70a08231", "18160ddD", "0xA9059cbD" }));
        }

        [Fact]
        public void Test()
        {
            var byteCode = "6102016000526002601E20";
            var programInstructions = ProgramInstructionsUtils.DisassembleToString(byteCode);
            Debug.WriteLine(programInstructions);
        }
    }
}