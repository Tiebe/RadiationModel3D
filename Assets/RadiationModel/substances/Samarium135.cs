
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium135 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium135";
        public override double halfLife { get; } = 10.3d;
        public override double atomicWeight { get; } = 134.93252d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Promethium135() } },

        };
    }
}
    
    