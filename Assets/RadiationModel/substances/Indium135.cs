
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium135 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium135";
        public override double halfLife { get; } = 0.103d;
        public override double atomicWeight { get; } = 134.94943d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tin135() } },

        };
    }
}
    
    