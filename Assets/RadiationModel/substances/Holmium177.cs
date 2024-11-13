
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium177 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium177";
        public override double halfLife { get; } = 1.0d;
        public override double atomicWeight { get; } = 176.96105d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Erbium177() } },

        };
    }
}
    
    