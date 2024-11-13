
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium78 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium78";
        public override double halfLife { get; } = 5.09d;
        public override double atomicWeight { get; } = 77.93161d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Germanium78() } },

        };
    }
}
    
    