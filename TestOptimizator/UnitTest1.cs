using System;
using CompilerConsole.Parser;
using CompilerConsole.Parser.Nodes;
using CompilerConsole.Parser.Nodes.BodyNodes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Type = CompilerConsole.Parser.Nodes.Type;

namespace TestOptimizator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLiterals() {
            var mok = this.CreateMok();

            var tested = new Optimizator(mok.Body);
            tested.Optimize();
            var result = (mok.Body.Nodes[0] as Expression).RightNode as Literals;
            Assert.IsNotNull(result);
            Assert.AreNotEqual(result.Value, 12);
        }

        private BodyNode CreateMok() {
            var mok = new MethodNode("test", Type.NotAType, new Body(), null);

            var expr = new Expression(new Literals(Type.VarInt, 10), new Literals(Type.VarInt, 2), ExprToken.Add );

            var ass = new Expression(new StructVariableNode("varName",Type.VarInt), expr, ExprToken.Ass);

            mok.Body.Nodes.Add(ass);
            return mok;
        }
    }
}
