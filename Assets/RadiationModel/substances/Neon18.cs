
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neon18 : RadioactiveSubstance
    {
        public override string name { get; } = "Neon18";
        public override double halfLife { get; } = 1.6642d;
        public override double atomicWeight { get; } = 18.00571d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Fluorine18() } },

        };
    }
}
    
    