using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CursoOnline.DominioTest._Utils
{
    public static class AssertExtension
    {
        public static void ComMensagem(this ArgumentException excepetion, string mensagem)
        {
            if (excepetion.Message.Equals(mensagem))
                Assert.True(true);
            else
                Assert.False(true, $"Esperava a mensagem '{mensagem}' e recebeu a mensagem '{excepetion.Message}'");
        }
    }
}
