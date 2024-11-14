using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium78 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium78";
        public override double halfLife { get; } = 5280.0d;
        public override double atomicWeight { get; } = 77.92285d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 955000.0), new Arsenic78() } },

        };
    }
}
    
    