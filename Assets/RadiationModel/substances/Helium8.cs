
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Helium8 : RadioactiveSubstance
    {
        public override string name { get; } = "Helium8";
        public override double halfLife { get; } = 0.1195d;
        public override double atomicWeight { get; } = 8.03393d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Lithium8() } },

        };
    }
}
    
    