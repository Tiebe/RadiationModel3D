
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum172 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum172";
        public override double halfLife { get; } = 2208.0d;
        public override double atomicWeight { get; } = 171.94489d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Hafnium172() } },

        };
    }
}
    
    