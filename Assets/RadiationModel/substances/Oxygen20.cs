
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Oxygen20 : RadioactiveSubstance
    {
        public override string name { get; } = "Oxygen20";
        public override double halfLife { get; } = 13.51d;
        public override double atomicWeight { get; } = 20.00408d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Fluorine20() } },

        };
    }
}
    
    