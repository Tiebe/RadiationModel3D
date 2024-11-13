
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium142 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium142";
        public override double halfLife { get; } = 68832.0d;
        public override double atomicWeight { get; } = 141.91005d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Neodymium142() } },

            { 0.000164d, new List<RadioactiveSubstance> { new Cerium142() } },

        };
    }
}
    
    