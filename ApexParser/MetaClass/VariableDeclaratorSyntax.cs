﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApexParser.Visitors;

namespace ApexParser.MetaClass
{
    public class VariableDeclaratorSyntax : BaseSyntax
    {
        public VariableDeclaratorSyntax()
        {
            Kind = SyntaxType.VariableDeclarator;
        }

        public override void Accept(ApexSyntaxVisitor visitor) => visitor.VisitVariableDeclarator(this);

        public string Identifier { get; set; }

        public string Expression { get; set; }
    }
}