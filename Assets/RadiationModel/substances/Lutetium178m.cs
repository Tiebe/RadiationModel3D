using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium178m : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium178m";
        public override double halfLife { get; } = 1386.0d;
        public override double atomicWeight { get; } = 177.94609d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2221400.0), new Hafnium178() } },

        };
    }
}
    
    