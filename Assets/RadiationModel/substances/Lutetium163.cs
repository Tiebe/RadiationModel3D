
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium163 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium163";
        public override double halfLife { get; } = 238.2d;
        public override double atomicWeight { get; } = 162.94118d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Ytterbium163() } },

        };
    }
}
    
    