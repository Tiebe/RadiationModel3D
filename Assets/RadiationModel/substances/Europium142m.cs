
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium142m : RadioactiveSubstance
    {
        public override string name { get; } = "Europium142m";
        public override double halfLife { get; } = 73.38d;
        public override double atomicWeight { get; } = 141.92393d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Samarium142() } },

        };
    }
}
    
    