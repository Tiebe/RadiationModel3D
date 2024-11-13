
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium162 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium162";
        public override double halfLife { get; } = 1132.2d;
        public override double atomicWeight { get; } = 161.93578d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Thulium162() } },

        };
    }
}
    
    