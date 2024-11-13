
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium192 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium192";
        public override double halfLife { get; } = 0.0322d;
        public override double atomicWeight { get; } = 191.99134d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Lead188() } },

        };
    }
}
    
    