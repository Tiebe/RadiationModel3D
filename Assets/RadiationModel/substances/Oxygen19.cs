
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Oxygen19 : RadioactiveSubstance
    {
        public override string name { get; } = "Oxygen19";
        public override double halfLife { get; } = 26.47d;
        public override double atomicWeight { get; } = 19.00358d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Fluorine19() } },

        };
    }
}
    
    