
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium232 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium232";
        public override double halfLife { get; } = 2022.0d;
        public override double atomicWeight { get; } = 232.04118d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.2d, new List<RadioactiveSubstance> { new AlphaParticle(), new Uranium228() } },

        };
    }
}
    
    